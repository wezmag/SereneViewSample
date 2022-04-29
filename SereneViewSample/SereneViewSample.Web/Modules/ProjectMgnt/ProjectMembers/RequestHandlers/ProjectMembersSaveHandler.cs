using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SereneViewSample.ProjectMgnt.ProjectMembersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneViewSample.ProjectMgnt.ProjectMembersRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectMembersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectMembersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectMembersSaveHandler
    {
        public ProjectMembersSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}