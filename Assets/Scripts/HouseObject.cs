using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseObject : MonoBehaviour
{
    public string Name { get; set; }
    public double BuyPrice { get; set; }
    public bool Bought { get; set; } = false;

    //Determites how much the house currently produces
    public double Production { get; set; }

    //Determites how much the house will produce after being bought
    public double ProductionStartValue { get; set; }

    //Determites how much more you produce after upgrading
    public double ProductionUpgradeValue { get; set; }

    public void buy()
    {
        if (MoneyController.CanBuy(BuyPrice))
        {
            Bought = true;
            Production = ProductionStartValue;
        }
    }

    public void Upgrade()
    {
        //add check if can be bought
        ProductionUpgradeValue *= 0.9;
        Production += ProductionUpgradeValue;
    }

}
