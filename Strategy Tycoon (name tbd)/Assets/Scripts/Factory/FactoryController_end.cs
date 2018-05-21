using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryController_end : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered");
        if (collision.tag == "Bullet")
        {
            Destroy(collision);
            FactoryController_start.money += FactoryController_start.valueLevel;
        }
    }
}
