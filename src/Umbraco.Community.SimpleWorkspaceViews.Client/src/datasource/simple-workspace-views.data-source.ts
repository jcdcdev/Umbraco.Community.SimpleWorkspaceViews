import { UmbControllerHost } from "@umbraco-cms/backoffice/controller-api";
import { UmbDataSourceResponse } from "@umbraco-cms/backoffice/repository";
import { tryExecute } from "@umbraco-cms/backoffice/resources";
import { UmbContextToken } from "@umbraco-cms/backoffice/context-api";
import { GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse, SimpleWorkspaceViews } from "../api";
import { SimpleWorkspaceViewsContext } from "../context/simple-workspace-views.context";

export const SIMPLE_WORKSPACE_VIEWS_CONTEXT_TOKEN =
    new UmbContextToken<SimpleWorkspaceViewsContext>("SimpleWorkspaceViewsContext");

export interface ISimpleWorkspaceViewsDataSource {
    render(alias: string, key: string): Promise<UmbDataSourceResponse<GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse>>;
}

export class SimpleWorkspaceViewsDataSource implements ISimpleWorkspaceViewsDataSource {

    #host: UmbControllerHost;

    constructor(host: UmbControllerHost) {
        this.#host = host;
    }

    async render(alias: string, key: string): Promise<UmbDataSourceResponse<GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse>> {
        const options = {
            path: {
                workspaceView: alias,
            },
            query: {
                key: key
            }
        };

        return await tryExecute(this.#host, SimpleWorkspaceViews.getUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceView(options))
    }
}
