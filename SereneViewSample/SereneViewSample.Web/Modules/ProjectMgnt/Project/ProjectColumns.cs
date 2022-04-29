using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Columns
{
    [ColumnsScript("ProjectMgnt.Project")]
    [BasedOnRow(typeof(ProjectRow), CheckNames = true)]
    public class ProjectColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string ProjectName { get; set; }
    }
}