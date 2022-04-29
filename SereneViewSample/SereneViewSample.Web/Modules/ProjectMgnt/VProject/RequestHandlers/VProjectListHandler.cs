using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneViewSample.ProjectMgnt.VProjectRow>;
using MyRow = SereneViewSample.ProjectMgnt.VProjectRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IVProjectListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class VProjectListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IVProjectListHandler
    {
        public VProjectListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}