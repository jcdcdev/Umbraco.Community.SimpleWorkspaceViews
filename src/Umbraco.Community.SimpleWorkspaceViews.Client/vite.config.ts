import {defineConfig} from "vite";

export default defineConfig({
    build: {
        lib: {
            entry: ["src/index.ts"],
            formats: ["es"],
        },
        outDir: "../Umbraco.Community.SimpleWorkspaceViews/wwwroot/App_Plugins/Umbraco.Community.SimpleWorkspaceViews/dist/",
        sourcemap: true,
        rollupOptions: {
            external: [/^@umbraco/],
        },
    },
});
