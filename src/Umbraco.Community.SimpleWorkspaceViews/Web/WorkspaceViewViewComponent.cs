using Microsoft.AspNetCore.Mvc;
using Umbraco.Community.SimpleWorkspaceViews.Web.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public abstract class WorkspaceViewViewComponent : ViewComponent
{
    public abstract IViewComponentResult Invoke(WorkspaceViewModel model);
}
