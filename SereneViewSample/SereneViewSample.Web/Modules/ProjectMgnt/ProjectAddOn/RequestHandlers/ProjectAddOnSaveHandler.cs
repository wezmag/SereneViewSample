using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SereneViewSample.ProjectMgnt.ProjectAddOnRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneViewSample.ProjectMgnt.ProjectAddOnRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectAddOnSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectAddOnSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectAddOnSaveHandler
    {
        public ProjectAddOnSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}