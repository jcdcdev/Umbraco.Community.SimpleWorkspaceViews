using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Infrastructure.Manifest;
using Umbraco.Community.SimpleWorkspaceViews.Core.Models;
using Umbraco.Community.SimpleWorkspaceViews.Web;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public static class UmbracoBuilderExtensions
{
    public static void AddSimpleWorkspaceViews(this IUmbracoBuilder builder)
    {
        var types = builder.TypeLoader.GetTypes<ISimpleWorkspaceView>();
        foreach (var type in types)
        {
            builder.SimpleWorkspaceViews().Append(type);
        }

        builder.Services.ConfigureOptions<ConfigApiSwaggerGenOptions>();
        builder.Services.AddSingleton<ISimpleWorkspaceViewService, SimpleWorkspaceViewService>();
        builder.Services.AddSingleton<IPackageManifestReader, SimpleWorkspaceViewPackageManifestReader>();
    }

    private static SimpleWorkspaceViewCollectionBuilder SimpleWorkspaceViews(this IUmbracoBuilder builder) => builder.WithCollectionBuilder<SimpleWorkspaceViewCollectionBuilder>();
}
