using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace adk
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody rb;
        public float forwardForce = -2000f;
        public bool canMove = false;
        void FixedUpdate() //does not depend on fps
        {
            if(!canMove) return; //if tap to play panel is still open
            rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

            if (rb.position.y < 0 || rb.position.x < -7.55 || rb.position.x > 7.55 )
            {
                //out of bounds, restart level and disable input canvas
            }
        }
        
        public void PlayerCanMoveTrue()
        {
            canMove = true;
        }
    }
    
    
}
