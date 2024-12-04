using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 8)] private float speed = 1.0f;
        private Rigidbody playerRigidbody;
        [SerializeField] private float force;
        public bool isGrounded;
      
        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement)
        {
            if (isGrounded)
            {
                 playerRigidbody.AddForce(movement*speed);
            }
        }

        public void JumpCharacter()
        {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                isGrounded = false;
                playerRigidbody.AddForce(transform.up * force, ForceMode.Impulse);
            }
        }
        private void Update()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            isGrounded = true;
        }

#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            speed = 2;
        }
#endif
    }
}
