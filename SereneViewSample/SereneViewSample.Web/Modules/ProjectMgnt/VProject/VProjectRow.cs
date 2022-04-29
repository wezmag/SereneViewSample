using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SereneViewSample.ProjectMgnt
{
    [ConnectionKey("Default"), Module("ProjectMgnt"), TableName("[dbo].[ViewProjects]")]
    [DisplayName("V Project"), InstanceName("V Project")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class VProjectRow : Row<VProjectRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Project Id"), NotNull, IdProperty]
        public int? ProjectId
        {
            get => fields.ProjectId[this];
            set => fields.ProjectId[this] = value;
        }

        [DisplayName("Project Name"), Size(30), NotNull, QuickSearch, NameProperty]
        public string ProjectName
        {
            get => fields.ProjectName[this];
            set => fields.ProjectName[this] = value;
        }

        [DisplayName("Project Add On Id")]
        public int? ProjectAddOnId
        {
            get => fields.ProjectAddOnId[this];
            set => fields.ProjectAddOnId[this] = value;
        }

        [DisplayName("Description"), Size(200)]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Event Date")]
        public DateTime? EventDate
        {
            get => fields.EventDate[this];
            set => fields.EventDate[this] = value;
        }

        [DisplayName("Event Description"), Size(200)]
        public string EventDescription
        {
            get => fields.EventDescription[this];
            set => fields.EventDescription[this] = value;
        }

        [DisplayName("Member Count")]
        public int? MemberCount
        {
            get => fields.MemberCount[this];
            set => fields.MemberCount[this] = value;
        }

        public VProjectRow()
            : base()
        {
        }

        public VProjectRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProjectId;
            public StringField ProjectName;
            public Int32Field ProjectAddOnId;
            public StringField Description;
            public DateTimeField EventDate;
            public StringField EventDescription;
            public Int32Field MemberCount;
        }
    }
}
