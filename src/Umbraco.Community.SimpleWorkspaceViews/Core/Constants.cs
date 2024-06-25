using System.Reflection;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public static class Constants
{
    public const string Area = "SimpleWorkspaceViews";

    public const string ExampleView =
        // language=razor
        """
        @inherits Umbraco.Community.SimpleWorkspaceViews.Web.WorkspaceViewViewPage

        <h1>Hello Umbraco</h1>
        <p>My WorkspaceView is: @Model.WorkspaceView.Alias</p>
        """;

    public const string ErrorView =
        // language=html
        """
        <div>
            <h1>WorkspaceView Not Found</h1>
        </div>
        """;

    public const string PackageName = "Simple Workspace Views";
    public const string ErrorViewPath = "~/Views/WorkspaceViews/ViewNotFound.cshtml";

    private static readonly string NameSpace = Assembly.GetEntryAssembly()?.GetName()?.Name ?? "YourNamespace";

    public static string ExampleViewComponent(string name) =>
        // language=csharp
        $$"""
          using Microsoft.AspNetCore.Mvc;
          using Umbraco.Community.SimpleWorkspaceViews.Web;

          namespace {{NameSpace}}.Views.Components;

          public class {{name}}ViewComponent : WorkspaceViewViewComponent
          {
              public override IViewComponentResult Invoke(WorkspaceViewModel model)
              {
                  return Content($"Hello {model.WorkspaceView.Alias}");
              }
          }
          """;

    public class Api
    {
        public const string ApiName = "SimpleWorkspaceViews";
    }
}
