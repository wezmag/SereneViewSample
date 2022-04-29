
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectMembersGrid extends Serenity.EntityGrid<ProjectMembersRow, any> {
        protected getColumnsKey() { return ProjectMembersColumns.columnsKey; }
        protected getDialogType() { return ProjectMembersDialog; }
        protected getIdProperty() { return ProjectMembersRow.idProperty; }
        protected getInsertPermission() { return ProjectMembersRow.insertPermission; }
        protected getLocalTextPrefix() { return ProjectMembersRow.localTextPrefix; }
        protected getService() { return ProjectMembersService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}