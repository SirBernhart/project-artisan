using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemiFixedCameraControl : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float distance;
    private bool isTurning;

    public void TurnCamera(bool turnRight)
    {
        if(turnRight)
            this.transform.RotateAround(target.position, Vector3.up, 45);
        else
            this.transform.RotateAround(target.position, Vector3.up, -45);
    }
}
