namespace SereneViewSample.MemberMgnt {
    export interface MemberRow {
        Id?: number;
        Name?: string;
    }

    export namespace MemberRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'MemberMgnt.Member';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name"
        }
    }
}
