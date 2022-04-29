using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SereneViewSample.ProjectMgnt.VProjectRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IVProjectDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class VProjectDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IVProjectDeleteHandler
    {
        public VProjectDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}