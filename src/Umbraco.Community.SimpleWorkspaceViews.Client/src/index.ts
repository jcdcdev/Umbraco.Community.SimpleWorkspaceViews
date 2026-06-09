import type {UmbEntryPointOnInit} from "@umbraco-cms/backoffice/extension-api";
import {ManifestLocalizations} from "./lang/manifests.ts";
import {SimpleWorkspaceViewsContext} from "./context/simple-workspace-views.context.ts";
import './components/simple-workspace-view.ts';

export const onInit: UmbEntryPointOnInit = (_host, extensionRegistry) => {
    extensionRegistry.registerMany(ManifestLocalizations);

    new SimpleWorkspaceViewsContext(_host);
};
