using Serenity.ComponentModel;
using System;

namespace SereneViewSample.ProjectMgnt.Columns
{
    [ColumnsScript("ProjectMgnt.ProjectHistoryEditor")]
    [BasedOnRow(typeof(ProjectHistoryRow), CheckNames = true)]
    public class ProjectHistoryEditorColumns
    {
        [EditLink]
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
    }
}