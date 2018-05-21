using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Unlocked : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.tag == "Bullet" || collision.tag == "nurse"))
        {
            Debug.Log("Enter");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.tag == "Bullet" || collision.tag == "nurse"))
        {
            Debug.Log("exit");
        }
    }
}
