import {ManifestLocalization} from "@umbraco-cms/backoffice/extension-registry";

export const ManifestLocalizations: Array<ManifestLocalization> = [
    {
        type: 'localization',
        alias: 'SimpleWorkspaceViews.lang.enus',
        name: 'English (US)',
        weight: 0,
        meta: {
            culture: 'en-us'
        },
        js: () => import('./en-us')
    },
    {
        type: 'localization',
        alias: 'SimpleWorkspaceViews.lang.engb',
        name: 'English (UK)',
        weight: 0,
        meta: {
            culture: 'en-gb'
        },
        js: () => import('./en-us')
    },
]
