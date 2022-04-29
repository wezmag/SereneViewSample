using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SereneViewSample.ProjectMgnt.VProjectRow>;
using MyRow = SereneViewSample.ProjectMgnt.VProjectRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IVProjectRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class VProjectRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IVProjectRetrieveHandler
    {
        public VProjectRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}