using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace adk
{
    public class PlayerCollision : MonoBehaviour
    {
        public UnityEvent onObstacleHit;
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.tag == "Obstacle")
            {
                onObstacleHit.Invoke();
                //player can move false
                //enable restart canvas
            } 
        }
    }
}
