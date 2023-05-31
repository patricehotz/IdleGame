using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    public GameObject BuyButton;
    HouseObject thishouse = new HouseObject()
    {
        BuyPrice = 0,
        Name = "Starter House",
        ProductionStartValue = 1,
        ProductionUpgradeValue = 1,
    };

    private void Start()
    {
        BuyButton.SetActive(false);
    }
    public void OnMouseDown()
    {
        BuyButton.SetActive(!BuyButton.activeSelf);
    }

    public void BuyHouse() 
    {
        if (!thishouse.Bought)
        {
            thishouse.Buy();
            if(thishouse.Bought)
            {
                MoneyController.HouseObjects.Add(thishouse);
            }
        }
    }

    public void UpgradeHouse()
    {
        if (thishouse.Bought) 
        {
            thishouse.Upgrade();
        }
    }
}
