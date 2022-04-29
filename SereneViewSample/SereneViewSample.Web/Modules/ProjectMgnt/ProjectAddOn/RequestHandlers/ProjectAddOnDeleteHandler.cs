using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SereneViewSample.ProjectMgnt.ProjectAddOnRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectAddOnDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectAddOnDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProjectAddOnDeleteHandler
    {
        public ProjectAddOnDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}