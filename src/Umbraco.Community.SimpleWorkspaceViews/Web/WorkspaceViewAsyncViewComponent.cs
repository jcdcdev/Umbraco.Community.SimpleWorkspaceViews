using Microsoft.AspNetCore.Mvc;
using Umbraco.Community.SimpleWorkspaceViews.Web.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public abstract class WorkspaceViewAsyncViewComponent : ViewComponent
{
    public abstract Task<IViewComponentResult> InvokeAsync(WorkspaceViewModel model);
}
