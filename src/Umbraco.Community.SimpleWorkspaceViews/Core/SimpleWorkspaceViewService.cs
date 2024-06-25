using System.Collections.Concurrent;
using Humanizer;
using Microsoft.Extensions.Logging;
using Umbraco.Community.SimpleWorkspaceViews.Core.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public class SimpleWorkspaceViewService : ISimpleWorkspaceViewService
{
    private readonly ConcurrentDictionary<string, ISimpleWorkspaceView> _simpleWorkspaceViews;

    public SimpleWorkspaceViewService(SimpleWorkspaceViewCollection simpleWorkspaceViews, ILogger<SimpleWorkspaceViewService> logger)
    {
        _simpleWorkspaceViews = new ConcurrentDictionary<string, ISimpleWorkspaceView>();
        foreach (var simpleWorkspaceView in simpleWorkspaceViews)
        {
            if (!_simpleWorkspaceViews.TryAdd(simpleWorkspaceView.Alias.Kebaberize(), simpleWorkspaceView))
            {
                logger.LogWarning("SimpleWorkspaceView with alias {Alias} already exists, skipping", simpleWorkspaceView.Alias);
            }
        }
    }

    public ISimpleWorkspaceView? GetByAlias(string alias) => GetByPath(alias.Kebaberize());
    public ISimpleWorkspaceView? GetByPath(string path) => _simpleWorkspaceViews.TryGetValue(path.ToLowerInvariant(), out var workspaceView) ? workspaceView : null;

    public IEnumerable<ISimpleWorkspaceView> GetAll() => _simpleWorkspaceViews.Values;
}
