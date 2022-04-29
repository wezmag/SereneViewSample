namespace SereneViewSample.ProjectMgnt {
    export interface ProjectRow {
        Id?: number;
        ProjectName?: string;
        Description?: string;
        MemberList?: number[];
        ProjectHistories?: ProjectHistoryRow[];
    }

    export namespace ProjectRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ProjectName';
        export const localTextPrefix = 'ProjectMgnt.Project';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            ProjectName = "ProjectName",
            Description = "Description",
            MemberList = "MemberList",
            ProjectHistories = "ProjectHistories"
        }
    }
}
