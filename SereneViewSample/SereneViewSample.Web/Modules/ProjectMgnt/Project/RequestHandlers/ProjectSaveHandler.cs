using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SereneViewSample.ProjectMgnt.ProjectRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneViewSample.ProjectMgnt.ProjectRow;

namespace SereneViewSample.ProjectMgnt
{
    public interface IProjectSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProjectSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectSaveHandler
    {
        public ProjectSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void AfterSave()
        {
            base.AfterSave();
            if (this.IsCreate)
            {
                new ProjectAddOnSaveHandler(Context).Process(UnitOfWork, new SaveRequest<ProjectAddOnRow>() {
                    Entity = new ProjectAddOnRow
                    {
                        ProjectId = Row.Id,
                        Description = Row.Description
                    }
                }, SaveRequestType.Create);
            }
            if (this.IsUpdate)
            {
                var projectAddOnRow = Connection.TrySingle<ProjectAddOnRow>(new Criteria(ProjectAddOnRow.Fields.ProjectId) == this.Row.Id.Value);
                if (projectAddOnRow != null)
                {
                    projectAddOnRow.Description = this.Row.Description;
                    new ProjectAddOnSaveHandler(Context).Process(UnitOfWork, new SaveRequest<ProjectAddOnRow>()
                    {
                        Entity = projectAddOnRow,
                        EntityId = projectAddOnRow.Id.Value
                    }, SaveRequestType.Update);
                }
            }
        }
    }
}