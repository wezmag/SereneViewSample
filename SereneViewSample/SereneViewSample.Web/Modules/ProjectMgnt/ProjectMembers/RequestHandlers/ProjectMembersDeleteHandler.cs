using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SereneViewSample.ProjectMgnt.ProjectMembersRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectMembersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectMembersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProjectMembersDeleteHandler
    {
        public ProjectMembersDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}