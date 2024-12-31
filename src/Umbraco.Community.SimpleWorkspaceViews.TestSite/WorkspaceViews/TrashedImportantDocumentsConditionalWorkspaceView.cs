using jcdcdev.Umbraco.Core.Web.Models.Manifests;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Community.SimpleWorkspaceViews.Web;

namespace Umbraco.Community.SimpleWorkspaceViews.TestSite.WorkspaceViews;

public class TrashedImportantDocumentsConditionalWorkspaceView : SimpleWorkspaceView
{
    public override string Label => "Uh oh";
    public override int Weight => 900;

    public override IConditionManifest[] Conditions =>
    [
        ConditionManifest.EntityIsTrashed(),
        ConditionManifest.WorkspaceContentTypeAlias([Home.ModelTypeAlias, ContentPage.ModelTypeAlias])
    ];
}
