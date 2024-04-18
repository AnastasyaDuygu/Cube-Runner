using UnityEngine;
using UnityEngine.Events;

namespace adk
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody rb;
        public float forwardForce = -2000f;
        public bool canMove = false;

        public UnityEvent onPlayerOutOfBounds;
        private void OnEnable()
        {
            rb = GetComponent<Rigidbody>();
        }
        void FixedUpdate() //does not depend on fps
        {
            if (!canMove) return; //if tap to play panel is still open return
            rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

            if (rb.position.y < 0 || rb.position.x < -7.55 || rb.position.x > 7.55)
            {
                //out of bounds, restart level and disable input canvas
                onPlayerOutOfBounds.Invoke();
            }
        }
        public void PlayerCanMoveTrue()
        {
            canMove = true;
        }
        public void PlayerCanMoveFalse()
        {
            canMove = false;
        }
    }

}
