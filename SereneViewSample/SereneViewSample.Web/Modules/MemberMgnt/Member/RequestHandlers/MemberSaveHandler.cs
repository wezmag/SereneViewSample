using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SereneViewSample.MemberMgnt.MemberRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneViewSample.MemberMgnt.MemberRow;

namespace SereneViewSample.MemberMgnt
{
    public interface IMemberSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MemberSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMemberSaveHandler
    {
        public MemberSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}