namespace SereneViewSample.ProjectMgnt {
    export interface ProjectHistoryEditorForm {
        EventDate: Serenity.DateEditor;
        EventDescription: Serenity.StringEditor;
    }

    export class ProjectHistoryEditorForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMgnt.ProjectHistoryEditor';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProjectHistoryEditorForm.init)  {
                ProjectHistoryEditorForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.StringEditor;

                Q.initFormType(ProjectHistoryEditorForm, [
                    'EventDate', w0,
                    'EventDescription', w1
                ]);
            }
        }
    }
}
