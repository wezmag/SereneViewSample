namespace SereneViewSample.ProjectMgnt {
    export namespace VProjectService {
        export const baseUrl = 'ProjectMgnt/VProject';

        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<VProjectRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            List = "ProjectMgnt/VProject/List"
        }

        [
            'List'
        ].forEach(x => {
            (<any>VProjectService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
