using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirt.Models.Models;

namespace T_shirt.Models.ViewModels
{
    public class CategoryViewModel
    {

        public IEnumerable<Category> Category { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
