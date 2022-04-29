namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectHistoryEditor extends Serenity.Extensions.GridEditorBase<ProjectHistoryRow> {
        protected getColumnsKey() { return 'ProjectMgnt.ProjectHistoryEditor'; }
        protected getDialogType() { return ProjectHistoryEditorDialog; }
        protected getLocalTextPrefix() { return ProjectHistoryRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return 'Add';
        }
    }
}