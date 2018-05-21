using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    //private GameObject target;
    Rigidbody2D rb;

    void Start()
    {
        //target = GameObject.Find("FactoryEnd");
        rb = GetComponent<Rigidbody2D>();
    }

	void Update ()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, FactoryController_start.speedLevel/4);
        rb.velocity = new Vector2(1 * FactoryController_start.speedLevel / 4, 0);
    }
}
