using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace adk
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerCollision : MonoBehaviour
    {
        private Rigidbody rb;
        public UnityEvent onObstacleHit;
        private void OnEnable()
        {
            rb = GetComponent<Rigidbody>();
        }
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
