using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactoryButtonsController : MonoBehaviour {

    public Text speed;
    public Text value;

    public string asciiBullet;

    private void Update()
    {
        asciiBullet = '\u204D'.ToString(); //⁍

        value.text = FactoryController_start.valuePrice.ToString() + asciiBullet;
        speed.text = FactoryController_start.speedPrice.ToString() + asciiBullet;
    }

	public void speedPressed()
    {
        if (FactoryController_start.bullets >= FactoryController_start.speedPrice)
        {
            FactoryController_start.bullets -= FactoryController_start.speedPrice;
            if (FactoryController_start.speedPrice >= 50) { FactoryController_start.speedPrice += 50; } else { FactoryController_start.speedPrice += 40; }
            FactoryController_start.speedLevel += 1;
        }
    }

    public void valuePressed()
    {
        if (FactoryController_start.bullets >= FactoryController_start.valuePrice)
        {
            FactoryController_start.bullets -= FactoryController_start.valuePrice;
            FactoryController_start.valuePrice += 10;
            FactoryController_start.valueLevel += 1;
        }
    }
}
