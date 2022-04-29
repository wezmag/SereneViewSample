using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SereneViewSample.ProjectMgnt.ProjectHistoryRow>;
using MyRow = SereneViewSample.ProjectMgnt.ProjectHistoryRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectHistoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectHistoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectHistoryRetrieveHandler
    {
        public ProjectHistoryRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}