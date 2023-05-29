using UnityEngine;

namespace EasyUI.Tabs
{
    [DisallowMultipleComponent]
    [AddComponentMenu("EasyUI/Tabs/Tabs - Horizontal")]
    public partial class TabsUIHorizontal : TabsUI
    {
#if UNITY_EDITOR
        private void OnValidate()
        {
            base.Validate(TabsType.Horizontal);
        }
#endif // UNITY_EDITOR
    }
}
