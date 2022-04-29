using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneViewSample.MemberMgnt.MemberRow>;
using MyRow = SereneViewSample.MemberMgnt.MemberRow;

namespace SereneViewSample.MemberMgnt
{
    public interface IMemberListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MemberListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMemberListHandler
    {
        public MemberListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}