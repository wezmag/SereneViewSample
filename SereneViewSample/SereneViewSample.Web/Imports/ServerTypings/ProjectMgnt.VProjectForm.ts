namespace SereneViewSample.ProjectMgnt {
    export interface VProjectForm {
        ProjectName: Serenity.StringEditor;
        ProjectAddOnId: Serenity.IntegerEditor;
        Description: Serenity.StringEditor;
        EventDate: Serenity.DateEditor;
        EventDescription: Serenity.StringEditor;
        MemberCount: Serenity.IntegerEditor;
    }

    export class VProjectForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMgnt.VProject';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!VProjectForm.init)  {
                VProjectForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(VProjectForm, [
                    'ProjectName', w0,
                    'ProjectAddOnId', w1,
                    'Description', w0,
                    'EventDate', w2,
                    'EventDescription', w0,
                    'MemberCount', w1
                ]);
            }
        }
    }
}
