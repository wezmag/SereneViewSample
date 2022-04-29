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
    }
}