using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SereneViewSample.ProjectMgnt.Pages
{

    [PageAuthorize(typeof(ProjectRow))]
    public class ProjectController : Controller
    {
        [Route("ProjectMgnt/Project")]
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMgnt/Project/ProjectIndex.cshtml");
        }
    }
}