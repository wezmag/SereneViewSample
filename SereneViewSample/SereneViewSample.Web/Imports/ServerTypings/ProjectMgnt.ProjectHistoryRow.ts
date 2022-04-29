namespace SereneViewSample.ProjectMgnt {
    export interface ProjectHistoryRow {
        Id?: number;
        EventDate?: string;
        EventDescription?: string;
        ProjectId?: number;
        ProjectProjectName?: string;
    }

    export namespace ProjectHistoryRow {
        export const idProperty = 'Id';
        export const nameProperty = 'EventDescription';
        export const localTextPrefix = 'ProjectMgnt.ProjectHistory';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            EventDate = "EventDate",
            EventDescription = "EventDescription",
            ProjectId = "ProjectId",
            ProjectProjectName = "ProjectProjectName"
        }
    }
}
