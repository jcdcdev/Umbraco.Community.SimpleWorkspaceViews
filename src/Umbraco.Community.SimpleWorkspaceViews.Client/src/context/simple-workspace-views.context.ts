import {SimpleWorkspaceViewsRepository} from "../repository/simple-workspace-views.repository";
import {UmbControllerHost} from "@umbraco-cms/backoffice/controller-api";
import {UmbContextToken} from "@umbraco-cms/backoffice/context-api";
import {UmbControllerBase} from "@umbraco-cms/backoffice/class-api";
import {UmbDataSourceResponse} from "@umbraco-cms/backoffice/repository";
import {GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse} from "../api";

export const SIMPLE_WORKSPACE_VIEWS_CONTEXT_TOKEN =
    new UmbContextToken<SimpleWorkspaceViewsContext>("SimpleWorkspaceViewContext");

export class SimpleWorkspaceViewsContext extends UmbControllerBase {
    #repository: SimpleWorkspaceViewsRepository;

    constructor(host: UmbControllerHost) {
        super(host);
        this.provideContext(SIMPLE_WORKSPACE_VIEWS_CONTEXT_TOKEN, this);
        this.#repository = new SimpleWorkspaceViewsRepository(this);
    }

    async render(alias: string): Promise<UmbDataSourceResponse<GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse>> {
        return await this.#repository.render(alias);
    }
}
