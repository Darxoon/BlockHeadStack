using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Camera mainCam;

    private void Start()
    {
        mainCam = Camera.main;
    }

    private void Update()
    {
        transform.position = mainCam.ScreenToWorldPoint(Input.mousePosition) - new Vector3(0, 0, -5);
    }
}
