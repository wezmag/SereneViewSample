using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SereneViewSample.ProjectMgnt.VProjectRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneViewSample.ProjectMgnt.VProjectRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IVProjectSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class VProjectSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IVProjectSaveHandler
    {
        public VProjectSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}