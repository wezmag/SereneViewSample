using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace SereneViewSample.ProjectMgnt
{
    [ConnectionKey("Default"), Module("ProjectMgnt"), TableName("[dbo].[Project]")]
    [DisplayName("Project"), InstanceName("Project")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProjectRow : Row<ProjectRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Project Name"), Size(30), NotNull, QuickSearch, NameProperty]
        public string ProjectName
        {
            get => fields.ProjectName[this];
            set => fields.ProjectName[this] = value;
        }

        [DisplayName("Members")]
        [LinkingSetRelation(typeof(ProjectMembersRow), 
            nameof(ProjectMembersRow.Fields.ProjectId),
            nameof(ProjectMembersRow.Fields.MemberId))]
        public List<int> MemberList
        {
            get => fields.MemberList[this];
            set => fields.MemberList[this] = value;
        }

        public ProjectRow()
            : base()
        {
        }

        public ProjectRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField ProjectName;

            public ListField<int> MemberList;
        }
    }
}
