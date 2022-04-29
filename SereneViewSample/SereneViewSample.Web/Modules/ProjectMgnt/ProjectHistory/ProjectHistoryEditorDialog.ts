namespace SereneViewSample.ProjectMgnt {

    @Serenity.Decorators.registerClass()
    export class ProjectHistoryEditorDialog extends Serenity.Extensions.GridEditorDialog<ProjectHistoryRow> {
        protected getFormKey() { return ProjectHistoryEditorForm.formKey; }
        protected getLocalTextPrefix() { return ProjectHistoryRow.localTextPrefix; }

        protected form: ProjectHistoryEditorForm;

        constructor() {
            super();
            this.form = new ProjectHistoryEditorForm(this.idPrefix);
        }
    }
}