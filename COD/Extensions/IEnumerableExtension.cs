using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COD.Extensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> items, int selectedValue)
        {
            return from i in items
                   select new SelectListItem
                   {
                       Text = i.GetType().GetProperty("Name").GetValue(i).ToString(),
                       Value = i.GetType().GetProperty("Id").GetValue(i).ToString(),
                   };
        }
    }
}