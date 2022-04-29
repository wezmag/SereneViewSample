using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SereneViewSample.MemberMgnt.Pages
{

    [PageAuthorize(typeof(MemberRow))]
    public class MemberController : Controller
    {
        [Route("MemberMgnt/Member")]
        public ActionResult Index()
        {
            return View("~/Modules/MemberMgnt/Member/MemberIndex.cshtml");
        }
    }
}