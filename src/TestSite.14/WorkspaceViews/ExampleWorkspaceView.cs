using Umbraco.Community.SimpleWorkspaceViews.Web;

namespace TestSite.Fourteen.WorkspaceViews;

public class ExampleWorkspaceView : SimpleWorkspaceView
{
    public override int Weight => 500;
    public override string Name => "Example Workspace View";
    public override string Icon => "favorite";
    public override string[] Workspaces => ["Umb.Workspace.Media", "Umb.Workspace.Document"];
    public override string Label => "🦄";
}
