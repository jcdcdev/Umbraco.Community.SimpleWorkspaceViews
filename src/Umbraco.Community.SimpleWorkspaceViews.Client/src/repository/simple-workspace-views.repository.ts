import {UmbControllerBase} from "@umbraco-cms/backoffice/class-api";
import {UmbControllerHost} from "@umbraco-cms/backoffice/controller-api";
import {UmbDataSourceResponse} from "@umbraco-cms/backoffice/repository";
import {SimpleWorkspaceViewRenderModel} from "../api";
import {ISimpleWorkspaceViewsDataSource, SimpleWorkspaceViewsDataSource} from "../datasource/simple-workspace-views.data-source.ts";

export class SimpleWorkspaceViewsRepository extends UmbControllerBase {
    #resource: ISimpleWorkspaceViewsDataSource;

    constructor(host: UmbControllerHost) {
        super(host);
        this.#resource = new SimpleWorkspaceViewsDataSource(host);
    }

    async render(alias: string, key: string): Promise<UmbDataSourceResponse<SimpleWorkspaceViewRenderModel>> {
        return await this.#resource.render(alias, key);
    }
}
