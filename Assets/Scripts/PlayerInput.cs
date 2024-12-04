using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]

    public class PlayerInput: MonoBehaviour
    {
        private Vector3 movement;
        private Rigidbody playerRigidbody;
        private PlayerMovement playerMovement;

        public class GlobalStringVars
        {
            #region Input vars

            public const string HorizonalAxis = "Horizontal";
            public const string VerticalAxis = "Vertical";
            public const string JumpAxis = "Jump";
            public const string OpenAxis = "Open";

            #endregion
        }

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
            playerRigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HorizonalAxis);
            float vertical = Input.GetAxis(GlobalStringVars.VerticalAxis);
            float jump = Input.GetAxis(GlobalStringVars.JumpAxis);
            float open = Input.GetAxis (GlobalStringVars.OpenAxis);
            movement = new Vector3(horizontal, 0, vertical).normalized;
            //playerMovement.MoveCharacter(movement);
            playerMovement.JumpCharacter();
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movement);
        }
    }
}




   
