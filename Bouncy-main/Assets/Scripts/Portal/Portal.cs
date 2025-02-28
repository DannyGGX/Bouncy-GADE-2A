using UnityEngine;

namespace DefaultNamespace.Portal
{
    public class Portal : MonoBehaviour
    {
        [SerializeField] private Portal portalToTeleportTo;

        [SerializeField] private Vector3 teleportPosition;

        [SerializeField] private float timeBeforeTeleport;
        [HideInInspector] public bool canTeleport = true;

        private void OnCollisionEnter(Collision collision)
        {
            if (canTeleport == false) return;
            if (portalToTeleportTo.canTeleport == false) return;
            if (collision.gameObject.TryGetComponent<BallController>(out BallController ball))
            {
                ball.transform.position = teleportPosition;
                canTeleport = false;
            }
        }
        
        void OnCollisionExit(Collision collision)
        {
            canTeleport = true;
        }
    }
}