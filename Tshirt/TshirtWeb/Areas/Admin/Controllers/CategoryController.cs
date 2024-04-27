namespace TshirtWeb.Areas.Admin.Controllers
{

    using Microsoft.AspNetCore.Authorization;

    using Microsoft.AspNetCore.Mvc;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    using T_shirtStore.Utility;

    [Area("Admin")]
    [Authorize(Roles = StaticDetails.roleAdmin)]

    public class CategoryController : Controller
    {

        private readonly IUnitOfWork _UOF;

        public CategoryController(IUnitOfWork UOF)
        {

            _UOF = UOF;

        }


        public IActionResult Index()
        {

            List<Category> objCategoryList = _UOF.Category.GetAll().ToList();

            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Category obj)
        {

            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }

            if (obj.Name != null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is invalid value.");
            }

            if (ModelState.IsValid)
            {

                _UOF.Category.Add(obj);
                _UOF.Save();
                TempData["success"] = "Category created succeddsully";
                return RedirectToAction("Index");

            }
            return View();

        }

        public IActionResult Edit(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _UOF.Category.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }



        [HttpPost]



        public IActionResult Edit(Category obj)
        {

            if (ModelState.IsValid)
            {
                _UOF.Category.Update(obj);
                _UOF.Save();
                TempData["success"] = "Category edited succeddsully";
                return RedirectToAction("Index");
            }

            return View();

        }



        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _UOF.Category.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]

        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _UOF.Category.Get(u => u.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            _UOF.Category.Remove(obj);
            _UOF.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");

        }

    }
}
