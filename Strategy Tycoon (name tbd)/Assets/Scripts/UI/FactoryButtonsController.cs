using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactoryButtonsController : MonoBehaviour {

    public Text speed;
    public Text value;

    //public string asciiBullet;

    private void Update()
    {
        //asciiBullet = '\u204D'.ToString(); //⁍

        value.text = FactoryController_start.valPrice.ToString() + "⁍";
        speed.text = FactoryController_start.spePrice.ToString() + "⁍";
    }

	public void speedPressed()
    {
        if (FactoryController_start.bullets >= FactoryController_start.spePrice)
        {
            FactoryController_start.bullets -= FactoryController_start.spePrice;
            if (FactoryController_start.spePrice >= 50) { FactoryController_start.spePrice += 50; } else { FactoryController_start.spePrice += 40; }
            FactoryController_start.speLevel += 1;
        }
    }

    public void valuePressed()
    {
        if (FactoryController_start.bullets >= FactoryController_start.valPrice)
        {
            FactoryController_start.bullets -= FactoryController_start.valPrice;
            FactoryController_start.valPrice += 10;
            FactoryController_start.valLevel += 1;
        }
    }
}
