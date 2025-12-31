# Umbraco.Community.SimpleWorkspaceViews

[![Documentation](https://img.shields.io/badge/Docs-Quickstart-394933?style=flat&logo=github)](https://github.com/jcdcdev/Umbraco.Community.SimpleWorkspaceViews#quick-start)
[![Umbraco Marketplace](https://img.shields.io/badge/Umbraco-Marketplace-%233544B1?style=flat&logo=umbraco)](https://marketplace.umbraco.com/package/Umbraco.Community.SimpleWorkspaceViews)
[![License](https://img.shields.io/github/license/jcdcdev/Umbraco.Community.SimpleWorkspaceViews?color=8AB803&label=License&logo=github)](https://github.com/jcdcdev/Umbraco.Community.SimpleWorkspaceViews?tab=MIT-1-ov-file)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Umbraco.Community.SimpleWorkspaceViews?color=cc9900&label=Downloads&logo=nuget)](https://www.nuget.org/packages/Umbraco.Community.SimpleWorkspaceViews)
[![Project Website](https://img.shields.io/badge/Project%20Website-jcdc.dev-jcdcdev?style=flat&color=3c4834&logo=data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxNiIgaGVpZ2h0PSIxNiIgZmlsbD0id2hpdGUiIGNsYXNzPSJiaSBiaS1wYy1kaXNwbGF5IiB2aWV3Qm94PSIwIDAgMTYgMTYiPgogIDxwYXRoIGQ9Ik04IDFhMSAxIDAgMCAxIDEtMWg2YTEgMSAwIDAgMSAxIDF2MTRhMSAxIDAgMCAxLTEgMUg5YTEgMSAwIDAgMS0xLTF6bTEgMTMuNWEuNS41IDAgMSAwIDEgMCAuNS41IDAgMCAwLTEgMG0yIDBhLjUuNSAwIDEgMCAxIDAgLjUuNSAwIDAgMC0xIDBNOS41IDFhLjUuNSAwIDAgMCAwIDFoNWEuNS41IDAgMCAwIDAtMXpNOSAzLjVhLjUuNSAwIDAgMCAuNS41aDVhLjUuNSAwIDAgMCAwLTFoLTVhLjUuNSAwIDAgMC0uNS41TTEuNSAyQTEuNSAxLjUgMCAwIDAgMCAzLjV2N0ExLjUgMS41IDAgMCAwIDEuNSAxMkg2djJoLS41YS41LjUgMCAwIDAgMCAxSDd2LTRIMS41YS41LjUgMCAwIDEtLjUtLjV2LTdhLjUuNSAwIDAgMSAuNS0uNUg3VjJ6Ii8+Cjwvc3ZnPg==)](https://jcdc.dev/umbraco-packages/simple-workspace-views)


This packages aims to help developers quickly put together Umbraco Workspace Views using C#.

Looking for Umbraco Content Apps? Check out [Umbraco.Community.SimpleContentApps](https://github.com/jcdcdev/Umbraco.Community.SimpleContentApps)

- C# Workspace View creation
- No javascript or umbraco-package.json files required
- Supports both Views & View Components
- Easy to define section permissions


## Quick Start

### Install Package

```csharp
dotnet add package Umbraco.Community.SimpleWorkspaceViews 
```

### Register WorkspaceView

By default, this will display in the content section for Admins only.

```csharp title="BasicWorkspaceView.cs"
using Umbraco.Community.SimpleWorkspaceViews.Core; 
public class BasicWorkspaceView : SimpleWorkspaceView { }
```

### Create View

- Your view **must** go in `/Views/WorkspaceViews`
- You view **must** be the name of your C# class (without `WorkspaceView`)
    - For example: `BasicWorkspaceView.cs` => `/Views/WorkspaceViews/Basic.cshtml`

```razor title="Views/WorkspaceViews/Basic.cs"
@inherits Umbraco.Community.SimpleWorkspaceViews.Web.WorkspaceViewViewPage

<uui-box headline="Hello Umbraco">
    <p>My WorkspaceView is: @Model.WorkspaceView.Alias</p>
</uui-box>
```
### More examples

Check out [docs/examples.md](https://github.com/jcdcdev/Umbraco.Community.SimpleWorkspaceViews/blob/v15/docs/examples.md) for more complex examples.



## Contributing

Contributions to this package are most welcome! Please visit the [Contributing](https://github.com/jcdcdev/Umbraco.Community.SimpleWorkspaceViews/contribute) page.

## Acknowledgements (Thanks)

- LottePitcher  - [opinionated-package-starter](https://github.com/LottePitcher/opinionated-package-starter)



