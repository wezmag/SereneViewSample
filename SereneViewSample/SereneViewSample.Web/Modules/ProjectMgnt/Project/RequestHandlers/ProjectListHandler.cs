using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneViewSample.ProjectMgnt.ProjectRow>;
using MyRow = SereneViewSample.ProjectMgnt.ProjectRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProjectListHandler
    {
        public ProjectListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}