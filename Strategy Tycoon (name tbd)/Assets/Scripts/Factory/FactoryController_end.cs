using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryController_end : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            FactoryController_start.money += FactoryController_start.valueLevel;
        }
    }
}
