namespace SereneViewSample.ProjectMgnt {
    export interface ProjectHistoryForm {
        EventDate: Serenity.DateEditor;
        EventDescription: Serenity.StringEditor;
        ProjectId: Serenity.IntegerEditor;
    }

    export class ProjectHistoryForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMgnt.ProjectHistory';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProjectHistoryForm.init)  {
                ProjectHistoryForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ProjectHistoryForm, [
                    'EventDate', w0,
                    'EventDescription', w1,
                    'ProjectId', w2
                ]);
            }
        }
    }
}
