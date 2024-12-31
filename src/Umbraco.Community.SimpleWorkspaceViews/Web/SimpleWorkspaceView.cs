using Humanizer;
using jcdcdev.Umbraco.Core.Web.Models.Manifests;
using Umbraco.Community.SimpleWorkspaceViews.Core;
using Umbraco.Community.SimpleWorkspaceViews.Core.Models;
using Umbraco.Extensions;
using Constants = jcdcdev.Umbraco.Core.Constants;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public abstract class SimpleWorkspaceView : ISimpleWorkspaceView
{
    public virtual string ViewPath => $"~/Views/WorkspaceViews/{Alias}.cshtml";
    public virtual string ViewComponent => $"{Alias}WorkspaceView";
    public virtual string Icon => "document";
    public virtual IConditionManifest[] Conditions => BuildConditions().ToArray();

    public virtual int Weight => 100;
    public virtual string Label => Name;
    public virtual string Name => Alias;
    public string Alias => GetType().Name.Substring(0, GetType().Name.Length - "WorkspaceView".Length);
    public string PathName => Alias.Kebaberize();
    public virtual string[] Workspaces => [Constants.Workspaces.Document];

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

    protected List<IConditionManifest> BuildConditions()
    {
        var conditions = new List<IConditionManifest>();
        // TODO - Add when Umbraco has implemented oneOf for Workspaces
        // conditions.Add(ConditionManifest.WorkspaceAlias(workspaces));
        return conditions;
    }
}
