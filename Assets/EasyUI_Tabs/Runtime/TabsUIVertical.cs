using UnityEngine;

namespace EasyUI.Tabs
{
    [DisallowMultipleComponent]
    [AddComponentMenu("EasyUI/Tabs/Tabs - Vertical")]
    public partial class TabsUIVertical : TabsUI
    {
#if UNITY_EDITOR
        private void OnValidate()
        {
            base.Validate(TabsType.Vertical);
        }
#endif // UNITY_EDITOR
    }
}
