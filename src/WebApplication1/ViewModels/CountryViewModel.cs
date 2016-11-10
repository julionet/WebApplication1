using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class CountryViewModel
    {
        public static List<SelectListItem> GetCountries()
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            lista.Add(new SelectListItem { Value = "MX", Text = "Mexico" });
            lista.Add(new SelectListItem { Value = "CA", Text = "Canada" });
            lista.Add(new SelectListItem { Value = "US", Text = "USA" });
            return lista;
        }
    }
}
