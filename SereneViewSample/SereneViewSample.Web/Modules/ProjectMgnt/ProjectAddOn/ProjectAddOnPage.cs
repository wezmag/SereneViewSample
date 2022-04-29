using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SereneViewSample.ProjectMgnt.Pages
{

    [PageAuthorize(typeof(ProjectAddOnRow))]
    public class ProjectAddOnController : Controller
    {
        [Route("ProjectMgnt/ProjectAddOn")]
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMgnt/ProjectAddOn/ProjectAddOnIndex.cshtml");
        }
    }
}