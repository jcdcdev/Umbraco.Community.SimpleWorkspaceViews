using Umbraco.Community.SimpleWorkspaceViews.Core.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public class WorkspaceViewModel(ISimpleWorkspaceView workspaceView)
{
    public readonly ISimpleWorkspaceView WorkspaceView = workspaceView;
}
