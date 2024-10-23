﻿export const ManifestLocalizations: Array<UmbExtensionManifest> = [
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
