namespace SereneViewSample.MemberMgnt {
    export interface MemberForm {
        Name: Serenity.StringEditor;
    }

    export class MemberForm extends Serenity.PrefixedContext {
        static formKey = 'MemberMgnt.Member';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MemberForm.init)  {
                MemberForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(MemberForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
