using UnityEngine;
using UnityEngine.Events;

namespace adk
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject levelRestartCanvas;
        [SerializeField] private GameObject levelEndCanvas;

        public UnityEvent onLevelRestart;
        
        public void EnableRestartCanvas()
        {
            levelRestartCanvas.SetActive(true);
            //delay 1 seconds before refreshing level
            Invoke("DelayEvent", 1);
        }
        void DelayEvent()
        {
            onLevelRestart.Invoke(); //level manager reload scene
        }
        
        public void EnableEndCanvas()
        {
            levelEndCanvas.SetActive(true);
        }
    }
}
