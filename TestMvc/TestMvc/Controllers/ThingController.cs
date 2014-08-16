﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMvc.Models;

namespace TestMvc.Controllers
{
    public class ThingController : Controller
    {
        public ViewResult Edit(string id)
        {
            ViewBag.Id = id;
            
            return View();
        }

        public PartialViewResult GetThing(string id)
        {
            var thing = new Thing()
            {
                Name = id,
                Body = "blah",
                Size = 2,
                IsEdited = false
            };

            return PartialView("Thing", thing);
        }

        [HttpPost]
        public JsonResult SaveThing(Thing thing)
        {
            var valid = ModelState.IsValid;

            ModelState.AddModelError("stuff", "Stuff is wrong!");

            return new JsonResult();
        }
    }
}
