using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace adk
{
    public class PlayerCollision : MonoBehaviour
    {
        public UnityEvent onObstacleHit;
        public UnityEvent onCoinHit;
        
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.tag == "Obstacle")
            {
                onObstacleHit.Invoke();
                //player can move false
                //enable restart canvas
            } 
        }
        private void OnTriggerEnter(Collider other) 
        {
            if(other.gameObject.tag == "Coin")
            {
                var endPos = other.transform.position;
                other.gameObject.transform.DOJump(endPos, 20, 1, .4f)
                    .OnComplete(() =>
                    {
                        Destroy(other.gameObject);
                    });
                
                onCoinHit.Invoke(); 
                //coin text jump (DOTween)
                //coin image animation (DOTween)
            }
        }
    }
}
