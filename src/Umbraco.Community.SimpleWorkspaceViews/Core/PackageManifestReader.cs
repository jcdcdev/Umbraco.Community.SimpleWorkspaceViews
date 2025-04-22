using System.Reflection;
using jcdcdev.Umbraco.Core.Extensions;
using jcdcdev.Umbraco.Core.Web.Models.Manifests;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public class PackageManifestReader(ISimpleWorkspaceViewService simpleWorkspaceViewService) : IPackageManifestReader
{
    public Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync()
    {
        var workspaceViews = simpleWorkspaceViewService.GetAll().ToList();
        if (!workspaceViews.Any())
        {
            return Task.FromResult<IEnumerable<PackageManifest>>(Array.Empty<PackageManifest>());
        }

        var extensions = new List<IManifest>();
        var packageManifest = new PackageManifest
        {
            Name = Constants.PackageName,
            Version = Assembly.GetAssembly(typeof(PackageManifestReader))?.GetName().Version?.ToSemVer()?.ToString() ?? "0.1.0",
            AllowPublicAccess = false,
            AllowTelemetry = true,
            Extensions = []
        };

        extensions.Add(new BackofficeEntryPointManifest
        {
            Name = "simple-workspace-views.entrypoint",
            Alias = "simple-workspace-views.entrypoint",
            Js = "/App_Plugins/Umbraco.Community.SimpleWorkspaceViews/dist/index.js"
        });

        foreach (var workspaceView in workspaceViews)
        {
            foreach (var workspace in workspaceView.Workspaces)
            {
                var manifest = new WorkspaceViewManifest
                {
                    Alias = workspaceView.UniqueAlias(workspace),
                    Name = workspaceView.UniqueName(workspace),
                    ElementName = "simple-workspace-view",
                    Weight = workspaceView.Weight,
                    Meta = new WorkspaceViewManifest.MetaManifest
                    {
                        Label = workspaceView.Label,
                        Pathname = workspaceView.PathName,
                        Icon = workspaceView.Icon
                    },
                    Conditions = workspaceView.Conditions.Any() ? workspaceView.Conditions : [ConditionManifest.WorkspaceAlias(workspace)]
                };
                extensions.Add(manifest);
            }
        }

        packageManifest.Extensions = extensions.OfType<object>().ToArray();
        return Task.FromResult<IEnumerable<PackageManifest>>([packageManifest]);
    }
}
