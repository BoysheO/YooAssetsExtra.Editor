using YooAsset.Editor;

namespace YooAssetsExtra.Editor.ActiveRules
{
    [DisplayName("安卓分组")]
    public class AndroidGroup: IActiveRule
    {
        public bool IsActiveGroup()
        {
#if UNITY_ANDROID
            return true;
#else
            return false;
#endif
        }
    }
}