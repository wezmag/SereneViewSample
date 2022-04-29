
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class VProjectDialog extends Serenity.EntityDialog<VProjectRow, any> {
        protected getFormKey() { return VProjectForm.formKey; }
        protected getIdProperty() { return VProjectRow.idProperty; }
        protected getLocalTextPrefix() { return VProjectRow.localTextPrefix; }
        protected getNameProperty() { return VProjectRow.nameProperty; }
        protected getService() { return VProjectService.baseUrl; }
        protected getDeletePermission() { return VProjectRow.deletePermission; }
        protected getInsertPermission() { return VProjectRow.insertPermission; }
        protected getUpdatePermission() { return VProjectRow.updatePermission; }

        protected form = new VProjectForm(this.idPrefix);

    }
}