using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SereneViewSample.ProjectMgnt
{
    [ConnectionKey("Default"), Module("ProjectMgnt"), TableName("[dbo].[ProjectHistory]")]
    [DisplayName("Project History"), InstanceName("Project History")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProjectHistoryRow : Row<ProjectHistoryRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Event Date"), NotNull]
        public DateTime? EventDate
        {
            get => fields.EventDate[this];
            set => fields.EventDate[this] = value;
        }

        [DisplayName("Event Description"), Size(200), NotNull, QuickSearch, NameProperty]
        public string EventDescription
        {
            get => fields.EventDescription[this];
            set => fields.EventDescription[this] = value;
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

        public ProjectHistoryRow()
            : base()
        {
        }

        public ProjectHistoryRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public DateTimeField EventDate;
            public StringField EventDescription;
            public Int32Field ProjectId;

            public StringField ProjectProjectName;
        }
    }
}
