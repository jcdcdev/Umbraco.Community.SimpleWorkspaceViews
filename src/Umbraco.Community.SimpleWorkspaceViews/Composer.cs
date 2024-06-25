using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Community.SimpleWorkspaceViews.Core;

namespace Umbraco.Community.SimpleWorkspaceViews;

internal class Composer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddSimpleWorkspaceViews();
    }
}
