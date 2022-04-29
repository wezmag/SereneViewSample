using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SereneViewSample.ProjectMgnt.Pages
{

    [PageAuthorize(typeof(VProjectRow))]
    public class VProjectController : Controller
    {
        [Route("ProjectMgnt/VProject")]
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMgnt/VProject/VProjectIndex.cshtml");
        }
    }
}