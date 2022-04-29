using Microsoft.AspNetCore.Mvc;
using Serenity;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = SereneViewSample.ProjectMgnt.VProjectRow;

namespace SereneViewSample.ProjectMgnt.Endpoints
{
    [Route("Services/ProjectMgnt/VProject/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class VProjectController : ServiceEndpoint
    {
        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IVProjectListHandler handler)
        {
            return handler.List(connection, request);
        }
    }
}