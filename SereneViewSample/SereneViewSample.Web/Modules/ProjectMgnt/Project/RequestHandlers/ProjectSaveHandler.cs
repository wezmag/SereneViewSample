using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SereneViewSample.ProjectMgnt.ProjectRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneViewSample.ProjectMgnt.ProjectRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectSaveHandler
    {
        public ProjectSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}