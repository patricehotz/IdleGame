using UnityEngine;

public class HouseObject : MonoBehaviour
{
    public string Name { get; set; }
    public double BuyPrice { get; set; }
    public bool Bought { get; set; } = false;

    //Determites how much the house currently produces
    public double Production { get; set; } = 0;

    //Determites how much the house will produce after being bought
    public double ProductionStartValue { get; set; }

    //Determites how much more you produce after upgrading
    public double ProductionUpgradeValue { get; set; }

    public void Buy()
    {
        if (MoneyController.CanBuy(BuyPrice))
        {
            MoneyController.CurrentMoney -= BuyPrice;
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
