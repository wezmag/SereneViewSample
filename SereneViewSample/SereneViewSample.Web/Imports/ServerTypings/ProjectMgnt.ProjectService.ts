namespace SereneViewSample.ProjectMgnt {
    export namespace ProjectService {
        export const baseUrl = 'ProjectMgnt/Project';

        export declare function Create(request: Serenity.SaveRequest<ProjectRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ProjectRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProjectRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "ProjectMgnt/Project/Create",
            Update = "ProjectMgnt/Project/Update",
            Delete = "ProjectMgnt/Project/Delete",
            Retrieve = "ProjectMgnt/Project/Retrieve"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve'
        ].forEach(x => {
            (<any>ProjectService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
