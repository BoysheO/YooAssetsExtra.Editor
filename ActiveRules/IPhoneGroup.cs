using YooAsset.Editor;

namespace YooAssetsExtra.Editor.ActiveRules
{
    [DisplayName("iphone分组")]
    public class IPhoneGroup: IActiveRule
    {
        public bool IsActiveGroup()
        {
#if UNITY_IOS
            return true;
#else
            return false;
#endif
        }
    }
}