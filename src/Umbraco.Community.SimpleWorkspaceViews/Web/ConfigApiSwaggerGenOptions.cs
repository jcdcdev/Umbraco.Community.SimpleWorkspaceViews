using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Umbraco.Community.SimpleWorkspaceViews.Core;

namespace Umbraco.Community.SimpleWorkspaceViews.Web;

public class ConfigApiSwaggerGenOptions : IConfigureOptions<SwaggerGenOptions>
{
    public void Configure(SwaggerGenOptions options)
    {
        options.SwaggerDoc(
            Constants.Api.ApiName,
            new OpenApiInfo
            {
                Title = "Simple WorkspaceViews Api",
                Version = "Latest",
                Description = "API for Simple WorkspaceViews"
            });
    }
}
