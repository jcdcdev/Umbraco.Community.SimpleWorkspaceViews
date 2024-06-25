# Umbraco.Community.SimpleWorkspaceViews

[![Umbraco Marketplace](https://img.shields.io/badge/Umbraco-Marketplace-%233544B1?style=flat&logo=umbraco)](https://marketplace.umbraco.com/package/umbraco.community.SimpleWorkspaceViews)
[![GitHub License](https://img.shields.io/github/license/jcdcdev/Umbraco.Community.SimpleWorkspaceViews?color=8AB803&label=License&logo=github)](https://github.com/jcdcdev/Umbraco.Community.SimpleWorkspaceViews/blob/v14/LICENSE)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Umbraco.Community.SimpleWorkspaceViews?color=cc9900&label=Downloads&logo=nuget)](https://www.nuget.org/packages/Umbraco.Community.SimpleWorkspaceViews/)
[![Project Website](https://img.shields.io/badge/Project%20Website-jcdc.dev-jcdcdev?style=flat&color=3c4834&logo=data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxNiIgaGVpZ2h0PSIxNiIgZmlsbD0id2hpdGUiIGNsYXNzPSJiaSBiaS1wYy1kaXNwbGF5IiB2aWV3Qm94PSIwIDAgMTYgMTYiPgogIDxwYXRoIGQ9Ik04IDFhMSAxIDAgMCAxIDEtMWg2YTEgMSAwIDAgMSAxIDF2MTRhMSAxIDAgMCAxLTEgMUg5YTEgMSAwIDAgMS0xLTF6bTEgMTMuNWEuNS41IDAgMSAwIDEgMCAuNS41IDAgMCAwLTEgMG0yIDBhLjUuNSAwIDEgMCAxIDAgLjUuNSAwIDAgMC0xIDBNOS41IDFhLjUuNSAwIDAgMCAwIDFoNWEuNS41IDAgMCAwIDAtMXpNOSAzLjVhLjUuNSAwIDAgMCAuNS41aDVhLjUuNSAwIDAgMCAwLTFoLTVhLjUuNSAwIDAgMC0uNS41TTEuNSAyQTEuNSAxLjUgMCAwIDAgMCAzLjV2N0ExLjUgMS41IDAgMCAwIDEuNSAxMkg2djJoLS41YS41LjUgMCAwIDAgMCAxSDd2LTRIMS41YS41LjUgMCAwIDEtLjUtLjV2LTdhLjUuNSAwIDAgMSAuNS0uNUg3VjJ6Ii8+Cjwvc3ZnPg==)](https://jcdc.dev/umbraco-packages/simple-WorkspaceViews)

This packages aims to help developers quickly put together Umbraco Workspace Views using C# only.

![Basic Workspace View in the Umbraco Office](https://raw.githubusercontent.com/jcdcdev/Umbraco.Community.SimpleWorkspaceViews/v14/docs/screenshot.png)

## Features

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

```csharp
using Umbraco.Community.SimpleWorkspaceViews.Core; 
public class BasicWorkspaceView : SimpleWorkspaceView { }
```

### Create View

- Your view **must** go in `/Views/WorkspaceView`
- You view **must** be the name of your C# class (without `WorkspaceView`)
    - For example: `BasicWorkspaceView.cs` => `/Views/WorkspaceView/Basic.cshtml`

```csharp
@inherits Umbraco.Community.SimpleWorkspaceViews.Web.WorkspaceViewViewPage

<uui-box headline="Hello Umbraco">
    <p>My WorkspaceView is: @Model.WorkspaceView.Alias</p>
</uui-box>
```

### More Examples

[docs/examples.md](https://github.com/jcdcdev/Umbraco.Community.SimpleWorkspaceViews/blob/v14/docs/examples.md)

## Contributing

Contributions to this package are most welcome! Please read
the [Contributing Guidelines](https://github.com/jcdcdev/Umbraco.Community.SimpleWorkspaceViews/blob/v14/.github/CONTRIBUTING.md).

## Acknowledgments (thanks!)

- LottePitcher - [opinionated-package-starter](https://github.com/LottePitcher/opinionated-package-starter)