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
            //delay 2 seconds before refreshing level
            Invoke("DelayEvent", 2);
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
