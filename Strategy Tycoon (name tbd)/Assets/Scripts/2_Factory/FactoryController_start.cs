﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryController_start : MonoBehaviour {

    public bool cheats;

    public GameObject bullet;
    private List<GameObject> lastShot = new List<GameObject>();
    private Transform factoryEnd;

    public static int bullets = 100;
    public static int spePrice = 10;
    public static int speLevel = 1;
    public static int valPrice = 10;
    public static int valLevel = 1;

    private bool next = true;

    private void Start()
    {
        factoryEnd = GameObject.Find("FactoryEnd").transform;
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
        if (Input.GetKeyDown("q") && cheats) { bullets *= 2; }

        if (next)
        {
            lastShot.Add(Instantiate(bullet, transform.position, transform.rotation));
            next = false;
        }

        for (int i=0; i<lastShot.Count; i++)
        {
            if (lastShot[i] == null)
            {
                lastShot.RemoveAt(i);
            }
            else
            {
                lastShot[i].GetComponent<Rigidbody2D>().velocity = new Vector2(FactoryController_start.speLevel, 0);
                if (lastShot[i].transform.position.x > factoryEnd.position.x)
                {
                    Destroy(lastShot[i]);
                    lastShot.RemoveAt(i);
                    bullets += valLevel;
                }
            }
        }
    }
}
