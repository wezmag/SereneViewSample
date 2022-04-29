using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Forms
{
    [FormScript("ProjectMgnt.ProjectHistoryEditor")]
    [BasedOnRow(typeof(ProjectHistoryRow), CheckNames = true)]
    public class ProjectHistoryEditorForm
    {
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
    }
}