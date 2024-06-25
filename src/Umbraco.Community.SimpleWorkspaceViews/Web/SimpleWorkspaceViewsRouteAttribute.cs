using Umbraco.Cms.Web.Common.Routing;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public class SimpleWorkspaceViewsRouteAttribute(string template) : BackOfficeRouteAttribute($"SimpleWorkspaceViews/api/v{{version:apiVersion}}/{template.TrimStart('/')}");
