import {css, html, LitElement, nothing} from 'lit';
import {customElement, state} from 'lit/decorators.js';
import {UmbElementMixin} from "@umbraco-cms/backoffice/element-api";
import {UUITextStyles} from "@umbraco-cms/backoffice/external/uui";
import {SIMPLE_WORKSPACE_VIEWS_CONTEXT_TOKEN} from "../context/simple-workspace-views.context";
import {unsafeHTML} from 'lit/directives/unsafe-html.js';
import {UMB_ENTITY_CONTEXT} from '@umbraco-cms/backoffice/entity';
import {ManifestWorkspaceView} from "@umbraco-cms/backoffice/workspace";
import {HtmlScriptContentRuntime} from "../utils/html-script-content-runtime";

@customElement('simple-workspace-view')
export class SimpleWorkspaceView extends UmbElementMixin(LitElement) {

    @state() private content: string | undefined;
    @state() private loading = true;

    private contentKey?: string;
    private workspaceAlias?: string;
    private readonly runtime = new HtmlScriptContentRuntime();

    constructor() {
        super();

        this.consumeContext(UMB_ENTITY_CONTEXT, (context) => {
            this.contentKey = context?.getUnique() ?? undefined;
        });

        this.consumeContext(SIMPLE_WORKSPACE_VIEWS_CONTEXT_TOKEN, async (context) => {
            if (!context || !this.contentKey) return;

            // @ts-ignore
            this.workspaceAlias = (this.manifest as ManifestWorkspaceView).alias;
            const response = await context.render(this.workspaceAlias, this.contentKey);
            this.content = response.data?.body;
            this.loading = false;
        });
    }

    protected updated(): void {
        void this.runtime.executeScripts(this.content, this.renderRoot);
    }

    render() {
        if (this.loading) return nothing;

        const body = this.runtime.extractHtml(this.content);
        return html`
            <div class="uui-text">
                ${body ? unsafeHTML(body) : html`<p>Workspace View not found</p>`}
            </div>
        `;
    }

    static styles = [
        UUITextStyles,
        css`
            :host {
                display: flex;
                flex-direction: column;
                gap: var(--uui-size-4);
                padding: var(--uui-size-layout-1);
            }
            pre {
                font-family: monospace;
                background-color: var(--uui-color-background);
                padding: var(--uui-size-layout-1);
            }
        `
    ];
}

declare global {
    interface HTMLElementTagNameMap {
        'simple-workspace-view': SimpleWorkspaceView;
    }
}
