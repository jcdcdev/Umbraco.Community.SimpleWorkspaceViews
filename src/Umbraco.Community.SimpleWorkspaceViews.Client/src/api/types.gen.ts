// This file is auto-generated by @hey-api/openapi-ts

export type SimpleWorkspaceViewRenderModel = {
    body: string;
};

export type GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewData = {
    workspaceView: string;
};

export type GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse = SimpleWorkspaceViewRenderModel;

export type $OpenApiTs = {
    '/umbraco/SimpleWorkspaceViews/api/v1/render/{workspaceView}': {
        get: {
            req: GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewData;
            res: {
                /**
                 * OK
                 */
                200: SimpleWorkspaceViewRenderModel;
            };
        };
    };
};