namespace T_shirt.Models.ViewModels
{
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using T_shirt.Models.Models;

    public class ProductViewModel
    {
        

        public Product Product { get; set;  }

        [ValidateNever]

        public IEnumerable<SelectListItem>  CategoryList { get; set; }


    }
}
