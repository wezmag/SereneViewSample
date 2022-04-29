using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SereneViewSample.ProjectMgnt.Pages
{

    [PageAuthorize(typeof(ProjectHistoryRow))]
    public class ProjectHistoryController : Controller
    {
        [Route("ProjectMgnt/ProjectHistory")]
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMgnt/ProjectHistory/ProjectHistoryIndex.cshtml");
        }
    }
}