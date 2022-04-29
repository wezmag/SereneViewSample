
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectAddOnGrid extends Serenity.EntityGrid<ProjectAddOnRow, any> {
        protected getColumnsKey() { return ProjectAddOnColumns.columnsKey; }
        protected getDialogType() { return ProjectAddOnDialog; }
        protected getIdProperty() { return ProjectAddOnRow.idProperty; }
        protected getInsertPermission() { return ProjectAddOnRow.insertPermission; }
        protected getLocalTextPrefix() { return ProjectAddOnRow.localTextPrefix; }
        protected getService() { return ProjectAddOnService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}