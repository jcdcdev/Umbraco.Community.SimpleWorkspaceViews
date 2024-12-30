using Umbraco.Community.SimpleWorkspaceViews.Core.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Web.Models;

public class WorkspaceViewModel(ISimpleWorkspaceView workspaceView, Guid contentKey)
{
    public readonly Guid ContentKey = contentKey;
    public readonly ISimpleWorkspaceView WorkspaceView = workspaceView;
}
