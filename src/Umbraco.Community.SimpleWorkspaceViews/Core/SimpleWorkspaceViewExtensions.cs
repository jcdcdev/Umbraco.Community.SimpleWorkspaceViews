using Umbraco.Community.SimpleWorkspaceViews.Core.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public static class SimpleWorkspaceViewExtensions
{
    public static string UniqueAlias(this ISimpleWorkspaceView workspaceView, string workspace)
    {
        return $"{workspaceView.Alias}-{workspace}";
    }

    public static string UniqueName(this ISimpleWorkspaceView workspaceView, string workspace)
    {
        return $"{workspaceView.Name} ({workspace})";
    }
}
