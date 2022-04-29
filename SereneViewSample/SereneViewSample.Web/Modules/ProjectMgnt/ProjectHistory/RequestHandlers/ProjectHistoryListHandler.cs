using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneViewSample.ProjectMgnt.ProjectHistoryRow>;
using MyRow = SereneViewSample.ProjectMgnt.ProjectHistoryRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectHistoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectHistoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProjectHistoryListHandler
    {
        public ProjectHistoryListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}