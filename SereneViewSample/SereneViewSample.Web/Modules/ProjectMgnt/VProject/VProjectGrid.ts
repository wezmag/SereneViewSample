
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class VProjectGrid extends Serenity.EntityGrid<VProjectRow, any> {
        protected getColumnsKey() { return VProjectColumns.columnsKey; }
        protected getDialogType() { return VProjectDialog; }
        protected getIdProperty() { return VProjectRow.idProperty; }
        protected getInsertPermission() { return VProjectRow.insertPermission; }
        protected getLocalTextPrefix() { return VProjectRow.localTextPrefix; }
        protected getService() { return VProjectService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}