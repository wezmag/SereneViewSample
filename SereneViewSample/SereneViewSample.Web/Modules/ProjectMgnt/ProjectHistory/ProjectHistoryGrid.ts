
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectHistoryGrid extends Serenity.EntityGrid<ProjectHistoryRow, any> {
        protected getColumnsKey() { return ProjectHistoryColumns.columnsKey; }
        protected getDialogType() { return ProjectHistoryDialog; }
        protected getIdProperty() { return ProjectHistoryRow.idProperty; }
        protected getInsertPermission() { return ProjectHistoryRow.insertPermission; }
        protected getLocalTextPrefix() { return ProjectHistoryRow.localTextPrefix; }
        protected getService() { return ProjectHistoryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}