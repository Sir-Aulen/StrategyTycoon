using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactoryButtonsController : MonoBehaviour {

    public Text money;
    public Text speed;
    public Text value;

    private void Update()
    {
        money.text = "$" + FactoryController_start.money.ToString();
        value.text = "$" + FactoryController_start.valuePrice.ToString();
        speed.text = "$" + FactoryController_start.speedPrice.ToString();
    }

	public void speedPressed()
    {
        if (FactoryController_start.money >= FactoryController_start.speedPrice)
        {
            FactoryController_start.money -= FactoryController_start.speedPrice;
            FactoryController_start.speedPrice += 10;
            FactoryController_start.speedLevel += 1;
        }
    }

    public void valuePressed()
    {
        if (FactoryController_start.money >= FactoryController_start.valuePrice)
        {
            FactoryController_start.money -= FactoryController_start.valuePrice;
            FactoryController_start.valuePrice += 10;
            FactoryController_start.valueLevel += 1;
        }
    }
}
