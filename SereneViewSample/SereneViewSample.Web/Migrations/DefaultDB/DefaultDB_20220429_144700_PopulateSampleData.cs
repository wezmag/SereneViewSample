using FluentMigrator;
using Serenity.Extensions;

namespace SereneViewSample.Migrations.DefaultDB
{
    [Migration(20220429_144700)]
    public class DefaultDB_20220429_144700_PopulateSampleData : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            this.Execute.Sql(@"
-- projects
SET IDENTITY_INSERT [dbo].[Project] ON
INSERT INTO [dbo].[Project] (Id, ProjectName) VALUES (1, N'First Project')
INSERT INTO [dbo].[Project] (Id, ProjectName) VALUES (2, N'Second Project')
SET IDENTITY_INSERT [dbo].[Project] OFF
-- projectaddon
INSERT INTO [dbo].[ProjectAddOn] (Description, ProjectId) VALUES (N'First Project Description', 1)
INSERT INTO [dbo].[ProjectAddOn] (Description, ProjectId) VALUES (N'Second Project Description', 2)

-- project history
INSERT INTO [dbo].[ProjectHistory] (EventDate, EventDescription, ProjectId) VALUES ('2020-10-01', 'First Project History 1', 1)
INSERT INTO [dbo].[ProjectHistory] (EventDate, EventDescription, ProjectId) VALUES ('2020-11-01', 'First Project History 2', 1)
INSERT INTO [dbo].[ProjectHistory] (EventDate, EventDescription, ProjectId) VALUES ('2020-12-01', 'First Project History 3', 1)
INSERT INTO [dbo].[ProjectHistory] (EventDate, EventDescription, ProjectId) VALUES ('2021-10-02', 'Second Project History 1', 2)
INSERT INTO [dbo].[ProjectHistory] (EventDate, EventDescription, ProjectId) VALUES ('2021-11-02', 'Second Project History 2', 2)
INSERT INTO [dbo].[ProjectHistory] (EventDate, EventDescription, ProjectId) VALUES ('2021-12-02', 'Second Project History 3', 2)
INSERT INTO [dbo].[ProjectHistory] (EventDate, EventDescription, ProjectId) VALUES ('2022-01-02', 'Second Project History 4', 2)

-- project member
INSERT INTO [dbo].[ProjectMembers] (ProjectId, MemberId) VALUES (1, 1)
INSERT INTO [dbo].[ProjectMembers] (ProjectId, MemberId) VALUES (1, 2)
INSERT INTO [dbo].[ProjectMembers] (ProjectId, MemberId) VALUES (1, 3)
INSERT INTO [dbo].[ProjectMembers] (ProjectId, MemberId) VALUES (1, 4)
INSERT INTO [dbo].[ProjectMembers] (ProjectId, MemberId) VALUES (2, 1)
INSERT INTO [dbo].[ProjectMembers] (ProjectId, MemberId) VALUES (2, 2)
INSERT INTO [dbo].[ProjectMembers] (ProjectId, MemberId) VALUES (2, 5)
");
        }
    }
}
