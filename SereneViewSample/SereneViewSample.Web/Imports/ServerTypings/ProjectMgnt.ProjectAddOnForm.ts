namespace SereneViewSample.ProjectMgnt {
    export interface ProjectAddOnForm {
        Description: Serenity.StringEditor;
        ProjectId: Serenity.IntegerEditor;
    }

    export class ProjectAddOnForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMgnt.ProjectAddOn';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProjectAddOnForm.init)  {
                ProjectAddOnForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(ProjectAddOnForm, [
                    'Description', w0,
                    'ProjectId', w1
                ]);
            }
        }
    }
}
