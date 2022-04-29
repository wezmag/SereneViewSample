using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.MemberMgnt.Forms
{
    [FormScript("MemberMgnt.Member")]
    [BasedOnRow(typeof(MemberRow), CheckNames = true)]
    public class MemberForm
    {
        public string Name { get; set; }
    }
}