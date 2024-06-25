using Umbraco.Community.SimpleWorkspaceViews.Core.Models;

namespace Umbraco.Community.SimpleWorkspaceViews.Core;

public interface ISimpleWorkspaceViewService
{
    ISimpleWorkspaceView? GetByAlias(string alias);
    ISimpleWorkspaceView? GetByPath(string path);
    IEnumerable<ISimpleWorkspaceView> GetAll();
}
