﻿using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SereneViewSample.Administration.Pages
{
    [PageAuthorize(typeof(Entities.LanguageRow))]
    public class LanguageController : Controller
    {
        [Route("Administration/Language")]
        public ActionResult Index()
        {
            return View(MVC.Views.Administration.Language.LanguageIndex);
        }
    }
}