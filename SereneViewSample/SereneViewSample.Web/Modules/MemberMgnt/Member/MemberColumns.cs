using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.MemberMgnt.Columns
{
    [ColumnsScript("MemberMgnt.Member")]
    [BasedOnRow(typeof(MemberRow), CheckNames = true)]
    public class MemberColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
    }
}