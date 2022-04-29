using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SereneViewSample.ProjectMgnt
{
    [ConnectionKey("Default"), Module("ProjectMgnt"), TableName("[dbo].[ProjectAddOn]")]
    [DisplayName("Project Add On"), InstanceName("Project Add On")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProjectAddOnRow : Row<ProjectAddOnRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Description"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Project"), NotNull, ForeignKey("[dbo].[Project]", "Id"), LeftJoin("jProject"), TextualField("ProjectProjectName")]
        public int? ProjectId
        {
            get => fields.ProjectId[this];
            set => fields.ProjectId[this] = value;
        }

        [DisplayName("Project Project Name"), Expression("jProject.[ProjectName]")]
        public string ProjectProjectName
        {
            get => fields.ProjectProjectName[this];
            set => fields.ProjectProjectName[this] = value;
        }

        public ProjectAddOnRow()
            : base()
        {
        }

        public ProjectAddOnRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Description;
            public Int32Field ProjectId;

            public StringField ProjectProjectName;
        }
    }
}
