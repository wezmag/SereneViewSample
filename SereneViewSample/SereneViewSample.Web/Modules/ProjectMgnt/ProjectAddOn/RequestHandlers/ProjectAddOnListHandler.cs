using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneViewSample.ProjectMgnt.ProjectAddOnRow>;
using MyRow = SereneViewSample.ProjectMgnt.ProjectAddOnRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectAddOnListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectAddOnListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProjectAddOnListHandler
    {
        public ProjectAddOnListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}