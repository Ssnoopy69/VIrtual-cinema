using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace StreamTG
{
    [RequireComponent(typeof(CharacterController))]

    public class Movement : MonoBehaviourPun
    {
        [SerializeField] private float movementSpeed = 0f;

        private CharacterController controller = null;

        private void start()
        {
            controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (photonView.IsMine)
            {
                TakeInput();
            }
        }

        private void TakeInput()
        {
            var movement = new Vector3
            {
                x = Input.GetAxisRaw("Horizontal"),
                y = 0f,
                z = Input.GetAxisRaw("Vertical"),
            }.normalized;

            controller.SimpleMove(movement * movementSpeed);
        }
    }

}
