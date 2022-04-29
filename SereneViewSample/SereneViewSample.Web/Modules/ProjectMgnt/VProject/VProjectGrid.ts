
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class VProjectGrid extends Serenity.EntityGrid<VProjectRow, any> {
        protected getColumnsKey() { return VProjectColumns.columnsKey; }
        protected getDialogType() { return ProjectDialog; } //we want to use Project Dialog to create/edit project
        protected getIdProperty() { return VProjectRow.idProperty; }
        protected getInsertPermission() { return VProjectRow.insertPermission; }
        protected getLocalTextPrefix() { return VProjectRow.localTextPrefix; }
        protected getService() { return VProjectService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}