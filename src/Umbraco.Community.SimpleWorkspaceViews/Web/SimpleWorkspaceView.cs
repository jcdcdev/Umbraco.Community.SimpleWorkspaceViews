using Humanizer;
using Umbraco.Community.SimpleWorkspaceViews.Core;
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
    public string Alias => GetType().Name.Substring(0, GetType().Name.Length - "WorkspaceView".Length);
    public string PathName => Alias.Kebaberize();
    public virtual string[] Workspaces => ["Umb.Workspace.Document"];
    public bool HasAlias(string alias)
    {
        if (alias.InvariantEquals(Alias))
        {
            return true;
        }

        var aliases = new List<string>();
        foreach (var workspace in Workspaces.ToList())
        {
            aliases.Add(this.UniqueAlias(workspace));
        }

        return aliases.InvariantContains(alias);
    }
}
