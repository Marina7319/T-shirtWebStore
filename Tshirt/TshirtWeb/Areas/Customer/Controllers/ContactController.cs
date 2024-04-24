using Microsoft.AspNetCore.Mvc;

namespace TshirtWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ContactController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
