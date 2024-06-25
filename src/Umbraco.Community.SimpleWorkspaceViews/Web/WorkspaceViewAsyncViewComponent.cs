using Microsoft.AspNetCore.Mvc;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public abstract class WorkspaceViewAsyncViewComponent : ViewComponent
{
    public abstract Task<IViewComponentResult> InvokeAsync(WorkspaceViewModel model);
}
