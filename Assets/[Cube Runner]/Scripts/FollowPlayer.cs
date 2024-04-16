using UnityEngine;

namespace adk
{
    public class FollowPlayer : MonoBehaviour
    {
        public Transform player;
        public Vector3 offset;
        void Update()
        {
            transform.position = player.position + offset;
        }
    }
}
