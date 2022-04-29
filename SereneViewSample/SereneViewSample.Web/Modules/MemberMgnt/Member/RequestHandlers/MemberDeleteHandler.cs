using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SereneViewSample.MemberMgnt.MemberRow;

namespace SereneViewSample.MemberMgnt
{
    public interface IMemberDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MemberDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMemberDeleteHandler
    {
        public MemberDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}