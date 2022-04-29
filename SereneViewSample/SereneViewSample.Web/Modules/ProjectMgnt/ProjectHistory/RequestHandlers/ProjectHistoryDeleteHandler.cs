using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SereneViewSample.ProjectMgnt.ProjectHistoryRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectHistoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectHistoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProjectHistoryDeleteHandler
    {
        public ProjectHistoryDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}