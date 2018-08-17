using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBindingCollectionDemo.Models;

namespace ModelBindingCollectionDemo.Controllers
{
    public class ParentController : Controller
    {
        public static List<EditChildViewModel> children = new List<EditChildViewModel> { new EditChildViewModel { Id = 1, Name = "Bob", Age = 2 },
                                                                                   new EditChildViewModel { Id = 2, Age = 4, Name = "Joy" },
                                                                                   new EditChildViewModel { Id = 3, Name = "Bill", Age = 13 } };

        public IActionResult EditParent()
        {
            var model = new EditParentViewModel();
            model.Children = children;
            return View(model);
        }

        [HttpPost]
        public IActionResult EditParent(EditParentViewModel model)
        {
            children = model.Children;
            return Redirect("/");
        }

        public IActionResult EditChild()
        {
            var model = new EditChildViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult EditChild(EditChildViewModel model)
        {
            return Redirect("/");
        }

    }
}