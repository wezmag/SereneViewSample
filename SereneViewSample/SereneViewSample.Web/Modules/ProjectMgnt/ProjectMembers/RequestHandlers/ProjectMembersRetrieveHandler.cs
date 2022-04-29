using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SereneViewSample.ProjectMgnt.ProjectMembersRow>;
using MyRow = SereneViewSample.ProjectMgnt.ProjectMembersRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectMembersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectMembersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectMembersRetrieveHandler
    {
        public ProjectMembersRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}