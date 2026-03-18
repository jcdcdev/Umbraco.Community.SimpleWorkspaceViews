## Detailed Register Workspace View

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

