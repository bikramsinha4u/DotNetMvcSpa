using DataAccessLayer;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DotNetMvcSpa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductViewModel vm = new ProductViewModel();

            vm.HandleRequest();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(ProductViewModel vm)
        {
            vm.IsValid = ModelState.IsValid;
            vm.HandleRequest();

            if (vm.IsValid)
                ModelState.Clear();
            else
            {
                foreach (KeyValuePair<string, string> item in vm.ValidationErrors)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }
            }

            return View(vm);
        }
    }
}