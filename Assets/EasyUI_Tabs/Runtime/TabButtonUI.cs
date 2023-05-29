using UnityEngine;
using UnityEngine.UI;

namespace EasyUI.Tabs
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Button), typeof(Image))]
    [AddComponentMenu("EasyUI/Tabs/Tab Button")]
    public class TabButtonUI : MonoBehaviour
    {
        public Button button { get; private set; }
        public Image image { get; private set; }
        // public LayoutElement layoutElement { get; private set; }

        private void OnValidate()
        {
            button = GetComponent<Button>();
            image = GetComponent<Image>();
            // layoutElement = GetComponent<LayoutElement>();
        }
    }
}
