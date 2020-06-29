using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COD.Models.ViewModels
{
    public class CategorySubCategoryViewModel
    {
        public Category Catgory { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
    }
}