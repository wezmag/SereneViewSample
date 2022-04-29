using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Forms
{
    [FormScript("ProjectMgnt.ProjectAddOn")]
    [BasedOnRow(typeof(ProjectAddOnRow), CheckNames = true)]
    public class ProjectAddOnForm
    {
        public string Description { get; set; }
        public int ProjectId { get; set; }
    }
}