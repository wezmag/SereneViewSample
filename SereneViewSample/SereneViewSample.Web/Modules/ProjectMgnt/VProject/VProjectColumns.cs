using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Columns
{
    [ColumnsScript("ProjectMgnt.VProject")]
    [BasedOnRow(typeof(VProjectRow), CheckNames = true)]
    public class VProjectColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int ProjectId { get; set; }
        [EditLink]
        public string ProjectName { get; set; }
        public int ProjectAddOnId { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public int MemberCount { get; set; }
    }
}