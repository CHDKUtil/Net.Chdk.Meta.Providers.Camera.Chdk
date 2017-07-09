using Net.Chdk.Meta.Model.Camera.Ps;
using Net.Chdk.Meta.Model.CameraList;
using Net.Chdk.Meta.Model.CameraTree;
using Net.Chdk.Meta.Providers.Camera.Ps;

namespace Net.Chdk.Meta.Providers.Camera.Chdk
{
    sealed class ChdkRevisionProvider : RevisionProvider
    {
        public override RevisionData GetRevision(string revision, TreeRevisionData treeRevision, ListPlatformData list, TreePlatformData tree)
        {
            return GetRevision(revision);
        }
    }
}
