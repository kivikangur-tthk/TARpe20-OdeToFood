using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {

        public IActionResult Search(string name = "french")
        {
            throw new Exception("Something terrible happend! :O");

            return Content("Esimene:"+name);
        }
    }
}
