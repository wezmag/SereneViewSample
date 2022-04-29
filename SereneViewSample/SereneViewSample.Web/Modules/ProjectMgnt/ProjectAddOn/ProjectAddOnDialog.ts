
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectAddOnDialog extends Serenity.EntityDialog<ProjectAddOnRow, any> {
        protected getFormKey() { return ProjectAddOnForm.formKey; }
        protected getIdProperty() { return ProjectAddOnRow.idProperty; }
        protected getLocalTextPrefix() { return ProjectAddOnRow.localTextPrefix; }
        protected getNameProperty() { return ProjectAddOnRow.nameProperty; }
        protected getService() { return ProjectAddOnService.baseUrl; }
        protected getDeletePermission() { return ProjectAddOnRow.deletePermission; }
        protected getInsertPermission() { return ProjectAddOnRow.insertPermission; }
        protected getUpdatePermission() { return ProjectAddOnRow.updatePermission; }

        protected form = new ProjectAddOnForm(this.idPrefix);

    }
}