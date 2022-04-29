using FluentMigrator;
using Serenity.Extensions;

namespace SereneViewSample.Migrations.DefaultDB
{
    public class DefaultDB_20220429_140400_AddTables : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            this.CreateTableWithId32("Project", "Id", s => s
                .WithColumn("ProjectName").AsString(30).NotNullable()
            );

            this.CreateTableWithId32("ProjectAddOn", "Id", s => s
                .WithColumn("Description").AsString(200).NotNullable()
                .WithColumn("ProjectId").AsInt32().NotNullable().Unique()
                    .ForeignKey("Project", "Id")
            );

            this.CreateTableWithId32("ProjectHistory", "Id", s => s
                .WithColumn("EventDate").AsDateTime().NotNullable()
                .WithColumn("EventDescription").AsString(200).NotNullable()
                .WithColumn("ProjectId").AsInt32().NotNullable()
                    .ForeignKey("Project", "Id")
            );

            this.CreateTableWithId32("Member", "Id", s => s
                .WithColumn("Name").AsString(100).NotNullable()
            );


            this.CreateTableWithId32("ProjectMembers", "Id", s => s
                .WithColumn("MemberId").AsInt32().NotNullable()
                    .ForeignKey("Member", "Id")
                .WithColumn("ProjectId").AsInt32().NotNullable()
                    .ForeignKey("Project", "Id")
            );

            this.Create.UniqueConstraint().OnTable("ProjectMembers")
                .Columns(new string[] { "MemberId", "ProjectId" });

            this.Insert.IntoTable("Member").Row(new { Name = "John Doe" });
            this.Insert.IntoTable("Member").Row(new { Name = "Jane Doe" });
            this.Insert.IntoTable("Member").Row(new { Name = "Fred Bloggs" });
            this.Insert.IntoTable("Member").Row(new { Name = "Joe Schmoe" });
            this.Insert.IntoTable("Member").Row(new { Name = "Jane Schmoe" });
            this.Insert.IntoTable("Member").Row(new { Name = "Freddy Schmoe" });
        }
    }
}
