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