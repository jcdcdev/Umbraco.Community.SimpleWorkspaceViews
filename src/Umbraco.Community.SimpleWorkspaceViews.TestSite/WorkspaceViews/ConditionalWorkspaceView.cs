using jcdcdev.Umbraco.Core;
using jcdcdev.Umbraco.Core.Web.Models.Manifests;
using Umbraco.Community.SimpleWorkspaceViews.Web;

namespace Umbraco.Community.SimpleWorkspaceViews.TestSite.WorkspaceViews;

public class ConditionalWorkspaceView : SimpleWorkspaceView
{
    public override string Label => "Conditional Workspace View";
    public override string[] Workspaces => [Constants.Workspaces.Media, Constants.Workspaces.Member];
}
