namespace SereneViewSample.ProjectMgnt {
    export interface ProjectForm {
        ProjectName: Serenity.StringEditor;
    }

    export class ProjectForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMgnt.Project';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProjectForm.init)  {
                ProjectForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(ProjectForm, [
                    'ProjectName', w0
                ]);
            }
        }
    }
}
