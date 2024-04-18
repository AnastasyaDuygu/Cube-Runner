using UnityEngine;
using UnityEngine.Events;

namespace adk
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject levelRestartCanvas;
        [SerializeField] private GameObject levelEndCanvas;

        public UnityEvent onLevelRestart;
        public UnityEvent onLevelEnd;
        public void EnableRestartCanvas()
        {
            levelRestartCanvas.SetActive(true);
            //delay 0.8 seconds before refreshing level
            Invoke("DelayRestartEvent", 0.8f);
        }
        void DelayRestartEvent()
        {
            onLevelRestart.Invoke(); //level manager reload scene
        }
        public void EnableEndCanvas()
        {
            levelEndCanvas.SetActive(true);
            //delay 0.8 seconds before refreshing level
            Invoke("DelayEndEvent", 0.8f);
        }
        void DelayEndEvent()
        {
            onLevelEnd.Invoke(); //level manager load next scene, save current coin amount
        }
    }
}
