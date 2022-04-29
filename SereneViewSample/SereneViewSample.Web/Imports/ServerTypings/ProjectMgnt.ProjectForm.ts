namespace SereneViewSample.ProjectMgnt {
    export interface ProjectForm {
        ProjectName: Serenity.StringEditor;
        MemberList: Serenity.LookupEditor;
        ProjectHistories: ProjectHistoryEditor;
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
                var w1 = s.LookupEditor;
                var w2 = ProjectHistoryEditor;

                Q.initFormType(ProjectForm, [
                    'ProjectName', w0,
                    'MemberList', w1,
                    'ProjectHistories', w2
                ]);
            }
        }
    }
}
