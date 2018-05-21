using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsController : MonoBehaviour {

    public Text text;

    private void Start()
    {
        text.text = "";
    }

    public void shopPressed()
    {
        changeText("shop");
    }

    public void factoryPressed()
    {
        changeText("factory");
    }

    public void armoryPressed()
    {
        changeText("armory");
    }

    public void mapPressed()
    {
        changeText("map");
    }

    public void changeText(string message)
    {
        text.text = message;
    }
}
