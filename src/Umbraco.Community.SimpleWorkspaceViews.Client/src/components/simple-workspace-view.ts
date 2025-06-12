import {css, html, LitElement, nothing} from 'lit';
import {customElement, state} from 'lit/decorators.js';
import {UmbElementMixin} from "@umbraco-cms/backoffice/element-api";
import {UUITextStyles} from "@umbraco-cms/backoffice/external/uui";
import {SIMPLE_WORKSPACE_VIEWS_CONTEXT_TOKEN} from "../context/simple-workspace-views.context";
import {unsafeHTML} from 'lit/directives/unsafe-html.js';
import {UMB_ENTITY_CONTEXT} from '@umbraco-cms/backoffice/entity';
import {ManifestWorkspaceView} from "@umbraco-cms/backoffice/workspace";

@customElement('simple-workspace-view')
export class SimpleWorkspaceView extends UmbElementMixin(LitElement) {

    @state()
    content: string | undefined;
    @state()
    loading: boolean = true;
    @state()
    contentKey?: string;
    @state()
    workspaceAlias?: string;

    constructor() {
        super();
        this.consumeContext(UMB_ENTITY_CONTEXT, (context) => {
            if (!context) {
                console.error('No entity context found');
                return;
            }
            this.contentKey = context.getUnique() ?? undefined;
        });

        this.consumeContext(SIMPLE_WORKSPACE_VIEWS_CONTEXT_TOKEN, async (context) => {
            if (!context) {
                console.error('No simple workspace views context found');
                return;
            }

            // @ts-ignore
            const manifest = this.manifest as ManifestWorkspaceView;
            this.workspaceAlias = manifest.alias;
            if (!this.contentKey) {
                return;
            }
            const response = await context.render(this.workspaceAlias, this.contentKey);
            this.loading = false;
            this.content = response.data?.body;
        });
    }

    render() {
        if (this.loading) {
            return nothing;
        }

        return html`
            <div class="uui-text">
                ${this.content ? unsafeHTML(this.content) : html`
                    <p>Workspace View not found</p>
                `}
            </div>
        `
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
                padding: var(--uui-size-layout-1)
            }
        `
    ]
}

declare global {
    interface HTMLElementTagNameMap {
        'simple-workspace-view': SimpleWorkspaceView;
    }
}
