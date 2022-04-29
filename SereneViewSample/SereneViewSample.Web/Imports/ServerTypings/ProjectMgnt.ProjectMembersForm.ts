namespace SereneViewSample.ProjectMgnt {
    export interface ProjectMembersForm {
        MemberId: Serenity.IntegerEditor;
        ProjectId: Serenity.IntegerEditor;
    }

    export class ProjectMembersForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMgnt.ProjectMembers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProjectMembersForm.init)  {
                ProjectMembersForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;

                Q.initFormType(ProjectMembersForm, [
                    'MemberId', w0,
                    'ProjectId', w0
                ]);
            }
        }
    }
}
