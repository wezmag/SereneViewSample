using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneViewSample.ProjectMgnt.ProjectMembersRow>;
using MyRow = SereneViewSample.ProjectMgnt.ProjectMembersRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectMembersListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectMembersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProjectMembersListHandler
    {
        public ProjectMembersListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}