using Umbraco.Cms.Core.Composing;
using Umbraco.Community.SimpleWorkspaceViews.Core.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public class SimpleWorkspaceViewCollection(Func<IEnumerable<ISimpleWorkspaceView>> items) : BuilderCollectionBase<ISimpleWorkspaceView>(items);
