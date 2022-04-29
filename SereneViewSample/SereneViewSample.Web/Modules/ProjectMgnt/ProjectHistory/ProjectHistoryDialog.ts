
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectHistoryDialog extends Serenity.EntityDialog<ProjectHistoryRow, any> {
        protected getFormKey() { return ProjectHistoryForm.formKey; }
        protected getIdProperty() { return ProjectHistoryRow.idProperty; }
        protected getLocalTextPrefix() { return ProjectHistoryRow.localTextPrefix; }
        protected getNameProperty() { return ProjectHistoryRow.nameProperty; }
        protected getService() { return ProjectHistoryService.baseUrl; }
        protected getDeletePermission() { return ProjectHistoryRow.deletePermission; }
        protected getInsertPermission() { return ProjectHistoryRow.insertPermission; }
        protected getUpdatePermission() { return ProjectHistoryRow.updatePermission; }

        protected form = new ProjectHistoryForm(this.idPrefix);

    }
}