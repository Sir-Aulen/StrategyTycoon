using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsController : MonoBehaviour {

    public Text title;

    /*public Text shop;
    public Text factory;
    public Text armory;
    public Text map;*/


    private int defaultSize;

    private void Start()
    {
        //shop = shop.GetComponent<Text>();

        //defaultSize = factory.GetComponent<Text>().cachedTextGenerator.fontSizeUsedForBestFit;

        //Debug.Log(defaultSize);
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            shop.fontSize = defaultSize;
            factory.fontSize = defaultSize;
            armory.fontSize = defaultSize;
            map.fontSize = defaultSize;
        }*/
    }

    public void shopPressed() { changeText("Shop"); }
    public void factoryPressed() { changeText("Factory");  }
    public void armoryPressed() { changeText("Armory"); }
    public void mapPressed(){ changeText("Map"); }

    public void changeText(string message)
    {
        title.text = message;
    }
}
