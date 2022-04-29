using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SereneViewSample.ProjectMgnt.Pages
{

    [PageAuthorize(typeof(ProjectMembersRow))]
    public class ProjectMembersController : Controller
    {
        [Route("ProjectMgnt/ProjectMembers")]
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMgnt/ProjectMembers/ProjectMembersIndex.cshtml");
        }
    }
}