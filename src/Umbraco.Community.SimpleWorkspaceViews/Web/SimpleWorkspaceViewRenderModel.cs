using Umbraco.Community.SimpleWorkspaceViews.Core;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public class SimpleWorkspaceViewRenderModel
{
    public string Body { get; set; } = string.Empty;
    public static SimpleWorkspaceViewRenderModel Error => new() { Body = Constants.ErrorView };
}
