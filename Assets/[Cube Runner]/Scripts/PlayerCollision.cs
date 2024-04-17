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
        
        public float stopingForce = 0;
        private void OnEnable()
        {
            rb = GetComponent<Rigidbody>();
            stopingForce = -FindObjectOfType<PlayerMovement>().forwardForce;
        }
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.tag == "Obstacle")
            {
                rb.AddForce(0, 0, stopingForce);
                onObstacleHit.Invoke();
                //player can move false
                //enable restart canvas
            } 
        }
    }
}
