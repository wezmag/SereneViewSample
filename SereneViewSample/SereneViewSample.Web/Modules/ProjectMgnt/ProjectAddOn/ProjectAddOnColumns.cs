using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Columns
{
    [ColumnsScript("ProjectMgnt.ProjectAddOn")]
    [BasedOnRow(typeof(ProjectAddOnRow), CheckNames = true)]
    public class ProjectAddOnColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Description { get; set; }
        public String ProjectProjectName { get; set; }
    }
}