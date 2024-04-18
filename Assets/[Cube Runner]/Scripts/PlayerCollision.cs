using UnityEngine;
using UnityEngine.Events;

namespace adk
{
    public class PlayerCollision : MonoBehaviour
    {
        public UnityEvent onObstacleHit;
        private Vector3 endPos;
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
                //Add Coin Collected Event
                //make coin jump
                    //endPos = other.transform.position;
                    //other.gameObject.transform.DOJump(endPos, jumpPower, jumpCount, duration);
                //coin image animation (DOTween)
                //coin text jump (DOTween)
            }
        }
    }
}
