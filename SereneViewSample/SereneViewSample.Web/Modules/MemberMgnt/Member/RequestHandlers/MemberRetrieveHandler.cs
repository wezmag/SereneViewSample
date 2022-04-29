using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SereneViewSample.MemberMgnt.MemberRow>;
using MyRow = SereneViewSample.MemberMgnt.MemberRow;

namespace SereneViewSample.MemberMgnt
{
    public interface IMemberRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MemberRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMemberRetrieveHandler
    {
        public MemberRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}