namespace SereneViewSample.ProjectMgnt {
    export namespace ProjectAddOnService {
        export const baseUrl = 'ProjectMgnt/ProjectAddOn';

        export declare function Create(request: Serenity.SaveRequest<ProjectAddOnRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ProjectAddOnRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ProjectAddOnRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ProjectAddOnRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "ProjectMgnt/ProjectAddOn/Create",
            Update = "ProjectMgnt/ProjectAddOn/Update",
            Delete = "ProjectMgnt/ProjectAddOn/Delete",
            Retrieve = "ProjectMgnt/ProjectAddOn/Retrieve",
            List = "ProjectMgnt/ProjectAddOn/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ProjectAddOnService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
