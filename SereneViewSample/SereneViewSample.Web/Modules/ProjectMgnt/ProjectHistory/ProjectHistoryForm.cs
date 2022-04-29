using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Forms
{
    [FormScript("ProjectMgnt.ProjectHistory")]
    [BasedOnRow(typeof(ProjectHistoryRow), CheckNames = true)]
    public class ProjectHistoryForm
    {
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public int ProjectId { get; set; }
    }
}