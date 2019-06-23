using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHead : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Camera mainCam;
    private bool dragging = false;
    private int distanceToPipe = 1000;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        mainCam = Camera.main;
    }


    private void Update()
    {
        if(dragging)
        {
            rigid.velocity = (mainCam.ScreenToWorldPoint(Input.mousePosition) - transform.position) / Time.deltaTime;
        }
    }


    public void OnMouseDown()
    {
        rigid.bodyType = RigidbodyType2D.Kinematic;
        dragging = true;
    }

    public void OnMouseUp()
    {
        rigid.bodyType = RigidbodyType2D.Dynamic;
        dragging = false;
    }

}
