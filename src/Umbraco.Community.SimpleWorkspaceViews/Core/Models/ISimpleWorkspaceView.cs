namespace Umbraco.Community.SimpleWorkspaceViews.Core.Models;

public interface ISimpleWorkspaceView
{
    string ViewComponent { get; }
    string ViewPath { get; }
    string[] Workspaces { get; }
    string Alias { get; }
    int Weight { get; }
    string? Name { get; }
    string Label { get; }
    string PathName { get; }
    string Icon { get; }
}
