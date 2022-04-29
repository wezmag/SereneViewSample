using FluentMigrator;

namespace SereneViewSample.Migrations.DefaultDB
{
    [Migration(20220429_150100)]
    public class DefaultDB_20220429_150100_AddView : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            this.Execute.Sql(@"
CREATE VIEW [dbo].[ViewProjects]
AS
SELECT 
T0.Id AS ProjectId,
T0.ProjectName AS ProjectName,
pa.Id AS ProjectAddOnId,
pa.Description AS Description,
ph.EventDate AS EventDate,
ph.EventDescription,
pm.MemberCount
FROM Project T0
LEFT JOIN ProjectAddOn pa ON T0.Id = pa.ProjectId
LEFT JOIN (SELECT ProjectId, COUNT(*) AS MemberCount FROM ProjectMembers GROUP BY ProjectId) pm ON pm.ProjectId = T0.Id
OUTER APPLY (
	SELECT TOP 1 * FROM ProjectHistory ph WHERE ph.ProjectId = T0.Id ORDER BY ph.EventDate DESC
) ph
GO
");
        }
    }
}
