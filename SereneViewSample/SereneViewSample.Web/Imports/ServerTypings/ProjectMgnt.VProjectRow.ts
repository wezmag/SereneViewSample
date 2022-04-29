namespace SereneViewSample.ProjectMgnt {
    export interface VProjectRow {
        ProjectId?: number;
        ProjectName?: string;
        ProjectAddOnId?: number;
        Description?: string;
        EventDate?: string;
        EventDescription?: string;
        MemberCount?: number;
    }

    export namespace VProjectRow {
        export const idProperty = 'ProjectId';
        export const nameProperty = 'ProjectName';
        export const localTextPrefix = 'ProjectMgnt.VProject';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProjectId = "ProjectId",
            ProjectName = "ProjectName",
            ProjectAddOnId = "ProjectAddOnId",
            Description = "Description",
            EventDate = "EventDate",
            EventDescription = "EventDescription",
            MemberCount = "MemberCount"
        }
    }
}
