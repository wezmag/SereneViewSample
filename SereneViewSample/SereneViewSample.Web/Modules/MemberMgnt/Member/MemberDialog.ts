
namespace SereneViewSample.MemberMgnt {

    @Serenity.Decorators.registerClass()
    export class MemberDialog extends Serenity.EntityDialog<MemberRow, any> {
        protected getFormKey() { return MemberForm.formKey; }
        protected getIdProperty() { return MemberRow.idProperty; }
        protected getLocalTextPrefix() { return MemberRow.localTextPrefix; }
        protected getNameProperty() { return MemberRow.nameProperty; }
        protected getService() { return MemberService.baseUrl; }
        protected getDeletePermission() { return MemberRow.deletePermission; }
        protected getInsertPermission() { return MemberRow.insertPermission; }
        protected getUpdatePermission() { return MemberRow.updatePermission; }

        protected form = new MemberForm(this.idPrefix);

    }
}