
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectGrid extends Serenity.EntityGrid<ProjectRow, any> {
        protected getColumnsKey() { return ProjectColumns.columnsKey; }
        protected getDialogType() { return ProjectDialog; }
        protected getIdProperty() { return ProjectRow.idProperty; }
        protected getInsertPermission() { return ProjectRow.insertPermission; }
        protected getLocalTextPrefix() { return ProjectRow.localTextPrefix; }
        protected getService() { return ProjectService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}