using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SereneViewSample.ProjectMgnt.ProjectHistoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneViewSample.ProjectMgnt.ProjectHistoryRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectHistorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectHistorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectHistorySaveHandler
    {
        public ProjectHistorySaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}