namespace SereneViewSample.ProjectMgnt {
    export interface ProjectAddOnRow {
        Id?: number;
        Description?: string;
        ProjectId?: number;
        ProjectProjectName?: string;
    }

    export namespace ProjectAddOnRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'ProjectMgnt.ProjectAddOn';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Description = "Description",
            ProjectId = "ProjectId",
            ProjectProjectName = "ProjectProjectName"
        }
    }
}
