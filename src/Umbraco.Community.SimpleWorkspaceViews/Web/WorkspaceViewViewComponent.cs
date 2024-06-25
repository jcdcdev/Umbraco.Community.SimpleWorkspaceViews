using Microsoft.AspNetCore.Mvc;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public abstract class WorkspaceViewViewComponent : ViewComponent
{
    public abstract IViewComponentResult Invoke(WorkspaceViewModel model);
}
