using YooAsset.Editor;

namespace YooAssetsExtra.Editor.ActiveRules
{
    [DisplayName("window分组")]
    public class WindowGroup: IActiveRule
    {
        public bool IsActiveGroup()
        {
#if UNITY_STANDALONE_WIN
            return true;
#else
            return false;
#endif
        }
    }
}