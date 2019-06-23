using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BlockHead")
        {
            Debug.Log("nice");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "BlockHead")
        {
            Debug.Log("bye");
        }
    }
}
