using Humanizer;
using Umbraco.Community.SimpleWorkspaceViews.Core.Models;
using Umbraco.Extensions;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public abstract class SimpleWorkspaceView : ISimpleWorkspaceView
{
    public virtual string ViewPath => $"~/Views/WorkspaceViews/{Alias}.cshtml";
    public virtual string ViewComponent => $"{Alias}WorkspaceView";
    public virtual string Icon => "document";
    public virtual int Weight => 100;
    public virtual string Label => Name;
    public virtual string Name => Alias;
    public string Alias => GetType().Name.TrimEnd("WorkspaceView");
    public string PathName => Alias.Kebaberize();
    public virtual string[] Workspaces => ["Umb.Workspace.Document"];
}
