﻿using UnityEngine;

class PlayerInput : MonoBehaviour
{
    float vertical, horizontal;
    [SerializeField] Movement playerMovement;
    [SerializeField] SemiFixedCameraControl semiFixedCamera;
    [SerializeField] private ItemCollector itemCollector;

    private void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Interact"))
        {
            itemCollector.CollectItem();
        }

        /*if(semiFixedCamera != null)
        {
            float rotateDirection = Input.GetKeyDown("Rotate camera");
            if(rotateDirection > 0)
                semiFixedCamera.TurnCamera(true);
            else
            {
                semiFixedCamera.TurnCamera(true);

            }
        }*/
    }

    private void FixedUpdate()
    {
        playerMovement.Move(horizontal, vertical);
    }
}
