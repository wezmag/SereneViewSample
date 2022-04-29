
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectDialog extends Serenity.EntityDialog<ProjectRow, any> {
        protected getFormKey() { return ProjectForm.formKey; }
        protected getIdProperty() { return ProjectRow.idProperty; }
        protected getLocalTextPrefix() { return ProjectRow.localTextPrefix; }
        protected getNameProperty() { return ProjectRow.nameProperty; }
        protected getService() { return ProjectService.baseUrl; }
        protected getDeletePermission() { return ProjectRow.deletePermission; }
        protected getInsertPermission() { return ProjectRow.insertPermission; }
        protected getUpdatePermission() { return ProjectRow.updatePermission; }

        protected form = new ProjectForm(this.idPrefix);

    }
}