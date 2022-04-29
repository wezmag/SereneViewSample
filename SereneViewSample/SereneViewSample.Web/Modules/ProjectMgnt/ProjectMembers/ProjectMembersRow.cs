using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SereneViewSample.ProjectMgnt
{
    [ConnectionKey("Default"), Module("ProjectMgnt"), TableName("[dbo].[ProjectMembers]")]
    [DisplayName("Project Members"), InstanceName("Project Members")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProjectMembersRow : Row<ProjectMembersRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Member"), NotNull, ForeignKey("[dbo].[Member]", "Id"), LeftJoin("jMember"), TextualField("MemberName")]
        public int? MemberId
        {
            get => fields.MemberId[this];
            set => fields.MemberId[this] = value;
        }

        [DisplayName("Project"), NotNull, ForeignKey("[dbo].[Project]", "Id"), LeftJoin("jProject"), TextualField("ProjectProjectName")]
        public int? ProjectId
        {
            get => fields.ProjectId[this];
            set => fields.ProjectId[this] = value;
        }

        [DisplayName("Member Name"), Expression("jMember.[Name]")]
        public string MemberName
        {
            get => fields.MemberName[this];
            set => fields.MemberName[this] = value;
        }

        [DisplayName("Project Project Name"), Expression("jProject.[ProjectName]")]
        public string ProjectProjectName
        {
            get => fields.ProjectProjectName[this];
            set => fields.ProjectProjectName[this] = value;
        }

        public ProjectMembersRow()
            : base()
        {
        }

        public ProjectMembersRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field MemberId;
            public Int32Field ProjectId;

            public StringField MemberName;

            public StringField ProjectProjectName;
        }
    }
}
