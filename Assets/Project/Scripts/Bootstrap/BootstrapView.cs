using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts.Bootstrap
{
    public class BootstrapView : MonoBehaviour
    {
        [SerializeField]
        private Slider _slider;

        [SerializeField]
        private TMP_Text _progressText;

        public void SetProgress(int progress)
        {
            _slider.value = progress / 100f;
            _progressText.text = $"{progress}%";
        }
    }
}
