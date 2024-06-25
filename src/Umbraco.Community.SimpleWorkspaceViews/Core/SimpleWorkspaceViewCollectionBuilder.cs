using Umbraco.Cms.Core.Composing;
using Umbraco.Community.SimpleWorkspaceViews.Core.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public class SimpleWorkspaceViewCollectionBuilder : OrderedCollectionBuilderBase<SimpleWorkspaceViewCollectionBuilder, SimpleWorkspaceViewCollection, ISimpleWorkspaceView>
{
    protected override SimpleWorkspaceViewCollectionBuilder This => this;
}
