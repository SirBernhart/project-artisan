using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChoose : MonoBehaviour
{

    public CinemachineVirtualCamera Cam01;
    public CinemachineVirtualCamera Cam02;
    public CinemachineVirtualCamera Cam03;
    public CinemachineVirtualCamera Cam04;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(("1")))
        {
            Cam01.Priority = 2;
            Cam02.Priority = 1;
            Cam03.Priority = 1;
            Cam04.Priority = 1;
            Debug.Log("1");
        }
        if (Input.GetKeyDown(("2")))
        {
            Cam01.Priority = 1;
            Cam02.Priority = 2;
            Cam03.Priority = 1;
            Cam04.Priority = 1;
            Debug.Log("2");
        }
        if (Input.GetKeyDown(("3")))
        {
            Cam01.Priority = 1;
            Cam02.Priority = 1;
            Cam03.Priority = 2;
            Cam04.Priority = 1;
            Debug.Log("3");
        }
        if (Input.GetKeyDown(("4")))
        {
            Cam01.Priority = 1;
            Cam02.Priority = 1;
            Cam03.Priority = 1;
            Cam04.Priority = 2;
            Debug.Log("4");
        }
    }
}
