using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArmoryButtonsController : MonoBehaviour {

    public Text active;
    public Text speed;
    public Text damage;
    public Text efficiency;

    private void Update()
    {
        speed.text = GunController.spePrice.ToString() + "⁍";
        damage.text = GunController.damPrice.ToString() + "⁍";
        efficiency.text = GunController.effPrice.ToString() + "⁍";

        if (GunController.active) { active.text = "Deactivate"; } else { active.text = "Activate"; }
    }

    public void activePressed()
    {
        if (GunController.active) { GunController.active = false; } else { GunController.active = true; }
    }
    public void SpeedPressed()
    {
        if (FactoryController_start.bullets >= GunController.spePrice)
        {
            FactoryController_start.bullets -= GunController.spePrice;
            GunController.spePrice += 10;
            GunController.speLevel += 1;
        }
    }
    public void DamagePressed()
    {
        if (FactoryController_start.bullets >= GunController.damPrice)
        {
            FactoryController_start.bullets -= GunController.damPrice;
            GunController.damPrice += 10;
            GunController.damLevel += 1;
        }
    }
    public void EfficiencyPressed()
    {
        if (FactoryController_start.bullets >= GunController.effPrice)
        {
            FactoryController_start.bullets -= GunController.effPrice;
            GunController.effPrice += 10;
            GunController.effLevel += 1;
        }
    }

}
