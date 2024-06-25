## Quick Start

### Install Package
```csharp
dotnet add package Umbraco.Community.SimpleWorkspaceViews 
```

### Register WorkspaceView

By default this will display in the content section for Admins only.
```csharp
using Umbraco.Community.SimpleWorkspaceViews.Core; 
public class BasicWorkspaceView : SimpleWorkspaceView { }
```

### Create View

- Your view **must** go in `/Views/WorkspaceView`
- You view **must** be the name of your C# class (without `WorkspaceView`)
  - For example: `BasicWorkspaceView.cs` => `/Views/WorkspaceView/Basic.cshtml` 
```csharp
@inherits Umbraco.Community.SimpleWorkspaceViews.WorkspaceViewViewPage

<uui-box headline="Hello Umbraco">
    <p>My Workspace View is: @Model.WorkspaceView.Alias</p>
</uui-box>
```

## Detailed Register Workspace View

By adding a constructor you can define permissions, where to display and the name of the Workspace View.

```csharp
using Umbraco.Community.SimpleWorkspaceViews.Core;

public class ExampleWorkspaceView : SimpleWorkspaceView
{
    public override int Weight => 500;
    public override string Name => "Example Workspace View";
    public override string Icon => "favorite";
    public override string[] Workspaces => ["Umb.Workspace.Media", "Umb.Workspace.Document"];
    public override string Label => "🦄";
}

```

## View Component Example

- Your View Component should match the name of your C# class plus `ViewComponent.cs`
  - For example: `BasicWorkspaceView.cs` => `BasicWorkspaceViewViewComponent.cs`
- Your View Component **must** inherit either:
  - `WorkspaceViewViewComponent`
  - `WorkspaceViewAsyncViewComponent`

```csharp
public class ExampleWorkspaceViewViewComponent : WorkspaceViewAsyncViewComponent
{
    public override Task<IViewComponentResult> InvokeAsync(WorkspaceViewModel model)
    {
        // Complex business logic
        var viewModel = await _service.CreateViewModel(model);
        // ...
        return View("~/Views/MyPath/MyView.cshtml", viewModel);
    }
}
```