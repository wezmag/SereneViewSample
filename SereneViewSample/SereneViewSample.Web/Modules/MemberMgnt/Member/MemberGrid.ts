
namespace SereneViewSample.MemberMgnt {

    @Serenity.Decorators.registerClass()
    export class MemberGrid extends Serenity.EntityGrid<MemberRow, any> {
        protected getColumnsKey() { return MemberColumns.columnsKey; }
        protected getDialogType() { return MemberDialog; }
        protected getIdProperty() { return MemberRow.idProperty; }
        protected getInsertPermission() { return MemberRow.insertPermission; }
        protected getLocalTextPrefix() { return MemberRow.localTextPrefix; }
        protected getService() { return MemberService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}