using Microsoft.AspNetCore.Mvc;
using Umbraco.Community.SimpleWorkspaceViews.Web;

namespace TestSite.ViewComponents.WorkspaceViews;

public class ExampleWorkspaceViewViewComponent : WorkspaceViewViewComponent
{
    public override IViewComponentResult Invoke(WorkspaceViewModel model)
    {
        return Content($"Hello {model.WorkspaceView.Name}");
    }
}
