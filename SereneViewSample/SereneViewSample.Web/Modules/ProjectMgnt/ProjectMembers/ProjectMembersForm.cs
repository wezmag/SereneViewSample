using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SereneViewSample.ProjectMgnt.Forms
{
    [FormScript("ProjectMgnt.ProjectMembers")]
    [BasedOnRow(typeof(ProjectMembersRow), CheckNames = true)]
    public class ProjectMembersForm
    {
        public int MemberId { get; set; }
        public int ProjectId { get; set; }
    }
}