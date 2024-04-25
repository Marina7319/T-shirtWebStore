

namespace T_shirt.Models.ViewModels
{
using T_shirt.Models.Models;
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products {  get; set; }

        public string CurrentCategory { get; set; }
    }
}
