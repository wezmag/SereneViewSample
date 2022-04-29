using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneViewSample.ProjectMgnt
{
    public partial class ProjectHistoryEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SereneViewSample.ProjectMgnt.ProjectHistoryEditor";

        public ProjectHistoryEditorAttribute()
            : base(Key)
        {
        }
    }
}
