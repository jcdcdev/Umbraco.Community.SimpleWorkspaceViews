import {UmbControllerBase} from "@umbraco-cms/backoffice/class-api";
import {UmbControllerHost} from "@umbraco-cms/backoffice/controller-api";
import {UmbDataSourceResponse} from "@umbraco-cms/backoffice/repository";
import {GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse} from "../api";
import {ISimpleWorkspaceViewsDataSource, SimpleWorkspaceViewsDataSource} from "../datasource/simple-workspace-views.data-source.ts";

export class SimpleWorkspaceViewsRepository extends UmbControllerBase {
    #resource: ISimpleWorkspaceViewsDataSource;

    constructor(host: UmbControllerHost) {
        super(host);
        this.#resource = new SimpleWorkspaceViewsDataSource(host);
    }

    async render(alias: string): Promise<UmbDataSourceResponse<GetUmbracoSimpleWorkspaceViewsApiV1RenderByWorkspaceViewResponse>> {
        return await this.#resource.render(alias);
    }
}
