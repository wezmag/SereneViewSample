using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SereneViewSample.ProjectMgnt.ProjectAddOnRow>;
using MyRow = SereneViewSample.ProjectMgnt.ProjectAddOnRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectAddOnRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectAddOnRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectAddOnRetrieveHandler
    {
        public ProjectAddOnRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}