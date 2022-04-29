
namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectMembersDialog extends Serenity.EntityDialog<ProjectMembersRow, any> {
        protected getFormKey() { return ProjectMembersForm.formKey; }
        protected getIdProperty() { return ProjectMembersRow.idProperty; }
        protected getLocalTextPrefix() { return ProjectMembersRow.localTextPrefix; }
        protected getService() { return ProjectMembersService.baseUrl; }
        protected getDeletePermission() { return ProjectMembersRow.deletePermission; }
        protected getInsertPermission() { return ProjectMembersRow.insertPermission; }
        protected getUpdatePermission() { return ProjectMembersRow.updatePermission; }

        protected form = new ProjectMembersForm(this.idPrefix);

    }
}