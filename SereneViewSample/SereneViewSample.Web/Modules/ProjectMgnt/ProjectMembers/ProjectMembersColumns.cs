using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Columns
{
    [ColumnsScript("ProjectMgnt.ProjectMembers")]
    [BasedOnRow(typeof(ProjectMembersRow), CheckNames = true)]
    public class ProjectMembersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public String MemberName { get; set; }
        public String ProjectProjectName { get; set; }
    }
}