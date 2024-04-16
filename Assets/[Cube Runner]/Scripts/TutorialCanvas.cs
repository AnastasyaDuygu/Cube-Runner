using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace adk
{
    public class TutorialCanvas : MonoBehaviour
    {
        [SerializeField] private Button tapToPlayButton;
    
        public UnityEvent onLevelStart;

        private void OnEnable()
        {
            tapToPlayButton.onClick.AddListener(OnStartButtonClicked);
        }
        private void OnDisable()
        {
            tapToPlayButton.onClick.RemoveAllListeners();
        }
        private void OnStartButtonClicked()
        {
            onLevelStart.Invoke();
        }

        public void DisableTapToPlayPanel()
        {
            gameObject.SetActive(false);
        }
        public void EnableTapToPlayPanel()
        {
            gameObject.SetActive(true);
        }
    }
}
