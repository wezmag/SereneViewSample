namespace SereneViewSample.ProjectMgnt {
    export interface ProjectMembersRow {
        Id?: number;
        MemberId?: number;
        ProjectId?: number;
        MemberName?: string;
        ProjectProjectName?: string;
    }

    export namespace ProjectMembersRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'ProjectMgnt.ProjectMembers';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            MemberId = "MemberId",
            ProjectId = "ProjectId",
            MemberName = "MemberName",
            ProjectProjectName = "ProjectProjectName"
        }
    }
}
