using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Columns
{
    [ColumnsScript("ProjectMgnt.ProjectHistory")]
    [BasedOnRow(typeof(ProjectHistoryRow), CheckNames = true)]
    public class ProjectHistoryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        [EditLink]
        public string EventDescription { get; set; }
        public String ProjectProjectName { get; set; }
    }
}