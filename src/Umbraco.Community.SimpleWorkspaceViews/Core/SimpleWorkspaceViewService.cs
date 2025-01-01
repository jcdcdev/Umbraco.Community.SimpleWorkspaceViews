using Microsoft.Extensions.Logging;
using Umbraco.Community.SimpleWorkspaceViews.Core.Models;
using Umbraco.Extensions;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public class SimpleWorkspaceViewService(
    SimpleWorkspaceViewCollection simpleWorkspaceViews,
    ILogger<SimpleWorkspaceViewService> logger)
    : ISimpleWorkspaceViewService
{
    public ISimpleWorkspaceView? GetByAlias(string alias) => simpleWorkspaceViews.FirstOrDefault(x => x.HasAlias(alias));
    public ISimpleWorkspaceView? GetByPath(string path) => simpleWorkspaceViews.FirstOrDefault(x => x.PathName.InvariantEquals(path));
    public IEnumerable<ISimpleWorkspaceView> GetAll() => simpleWorkspaceViews;
}
