import {UmbControllerHost} from "@umbraco-cms/backoffice/controller-api";
import {UmbDataSourceResponse} from "@umbraco-cms/backoffice/repository";
import {tryExecuteAndNotify} from "@umbraco-cms/backoffice/resources";
import {UmbContextToken} from "@umbraco-cms/backoffice/context-api";
import {
    getUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceView,
    GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewData,
    GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse
} from "../api";
import {SimpleWorkspaceViewsContext} from "../context/simple-workspace-views.context";

export const SIMPLE_WORKSPACE_VIEWS_CONTEXT_TOKEN =
    new UmbContextToken<SimpleWorkspaceViewsContext>("SimpleWorkspaceViewsContext");

export interface ISimpleWorkspaceViewsDataSource {
    render(alias: string): Promise<UmbDataSourceResponse<GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse>>;
}

export class SimpleWorkspaceViewsDataSource implements ISimpleWorkspaceViewsDataSource {

    #host: UmbControllerHost;

    constructor(host: UmbControllerHost) {
        this.#host = host;
    }

    async render(alias: string): Promise<UmbDataSourceResponse<GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse>> {
        const data: GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewData = {
            workspaceView: alias,
        };
        return await tryExecuteAndNotify(this.#host, getUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceView(data))
    }
}
