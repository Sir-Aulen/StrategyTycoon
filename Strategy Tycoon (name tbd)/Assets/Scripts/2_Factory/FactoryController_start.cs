using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryController_start : MonoBehaviour {

    public GameObject bullet;
    private GameObject start;

    public static int bullets = 100;
    public static int speedPrice = 10;
    public static int speedLevel = 1;
    public static int valuePrice = 10;
    public static int valueLevel = 1;

    private bool next = true;

    private void Start()
    {
        start = GameObject.Find("FactoryStart");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            next = true;
        }
    }

    private void Update()
    {
        if (next)
        {
            Instantiate(bullet, start.transform.position, start.transform.rotation);
            next = false;
        }
    }
}
