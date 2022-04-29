using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Forms
{
    [FormScript("ProjectMgnt.Project")]
    [BasedOnRow(typeof(ProjectRow), CheckNames = true)]
    public class ProjectForm
    {
        public string ProjectName { get; set; }

        [DisplayName("Description")]
        [TextAreaEditor(Rows = 3)]
        public string Description { get; set; }

        [LookupEditor(typeof(MemberMgnt.MemberRow), Multiple = true)]
        public List<int> MemberList { get; set; }
        
        [ProjectHistoryEditor]        
        public List<ProjectHistoryRow> ProjectHistories { get; set; }
    }
}