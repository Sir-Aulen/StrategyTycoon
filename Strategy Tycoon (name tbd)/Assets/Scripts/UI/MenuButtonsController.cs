using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsController : MonoBehaviour {

    public Text title;
    public Text bullets;

    //Keep font sizes the same
    /*public Text shop;
    public Text factory;
    public Text armory;
    public Text map;
    private int defaultSize;*/
    
    private List<GameObject> menuButtons = new List<GameObject>();

    private void Start()
    {
        bullets.text = " " + FactoryController_start.bullets.ToString() + "⁍";
        
        menuButtons.Add(GameObject.Find("ShopButtons"));
        menuButtons.Add(GameObject.Find("FactoryButtons"));
        menuButtons.Add(GameObject.Find("ArmoryButtons"));
        menuButtons.Add(GameObject.Find("MapButtons"));

        moveCamera(GameObject.Find("FactoryStuff").transform);
        activate("FactoryButtons");

        //Keep font sizes the same
        //shop = shop.GetComponent<Text>();
        //defaultSize = factory.GetComponent<Text>().cachedTextGenerator.fontSizeUsedForBestFit;
    }

    private void Update()
    {
        bullets.text = " " + FactoryController_start.bullets.ToString() + "⁍";

        //Keep font sizes the same
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            shop.fontSize = defaultSize;
            factory.fontSize = defaultSize;
            armory.fontSize = defaultSize;
            map.fontSize = defaultSize;
        }*/
    }

    public void shopPressed()
    {
        changeText("Shop");
        moveCamera(GameObject.Find("ShopStuff").transform);
        activate("ShopButtons");
    }
    public void factoryPressed()
    {
        changeText("Factory");
        moveCamera(GameObject.Find("FactoryStuff").transform);
        activate("FactoryButtons");
    }
    public void armoryPressed()
    {
        changeText("Armory");
        moveCamera(GameObject.Find("ArmoryStuff").transform);
        activate("ArmoryButtons");
    }
    public void mapPressed()
    {
        changeText("Map");
        moveCamera(GameObject.Find("MapStuff").transform);
        activate("MapButtons");
    }

    public void changeText(string message)
    {
        title.text = message;
    }

    private void moveCamera(Transform target)
    {
        GameObject camera = GameObject.Find("Main Camera");

        camera.transform.position = new Vector3 (target.position.x, target.position.y, -10);
    }

    private void activate(string target)
    {
         for (int i = 0; i < 4; i++)
         {
             if (target == menuButtons[i].name)
             {
                 menuButtons[i].SetActive(true);
             }
             else
             {
                 menuButtons[i].SetActive(false);
             }
         }
    }
}
