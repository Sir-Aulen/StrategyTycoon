using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public GameObject bullet;
    private GameObject lastShot;

    public static int speLevel = 1;     //Speed
    public static int spePrice = 20;
    public static int damLevel = 1;     //Damage
    public static int damPrice = 20;
    public static int effLevel = 1;     //Efficiency
    public static int effPrice = 20;
    
    private bool fireNext = true;
    private Animator anim;

    public static bool active;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
    }

    private void Update ()
    {
        if (active)
        {
            if (fireNext)
            {
                lastShot = Instantiate(bullet, transform.position, transform.rotation);
                lastShot.GetComponent<Rigidbody2D>().velocity = new Vector2(6, 0);
                FactoryController_start.bullets -= 1;
                fireNext = false;
            }

            anim.speed = (float)(speLevel * 0.16 + 1.4);
        }
        else
        {
            anim.speed = 0;
            anim.Play(0);
        }
        
	}

    public void nextShot()
    {
        fireNext = true;
        
    }
}
