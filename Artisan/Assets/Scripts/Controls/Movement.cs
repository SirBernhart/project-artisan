using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float gravity;
    [SerializeField] private GroundedChecker groundedChecker;
    private float downwardSpeed = 0;

    private void Start()
    {
        moveSpeed *= 100;
    }

    public void Move(float horizontal, float vertical)
    {
        if (groundedChecker.GetIsGrounded())
        {
            downwardSpeed = 0;
            rigidbody.velocity = new Vector3(horizontal, 0, vertical).normalized * moveSpeed * Time.deltaTime;
        }
        else
        {
            downwardSpeed += gravity;
            rigidbody.velocity = new Vector3(horizontal, -downwardSpeed, vertical).normalized * moveSpeed * Time.deltaTime;
        }
    }
}
