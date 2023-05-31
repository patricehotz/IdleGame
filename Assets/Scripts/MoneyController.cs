using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    // Start is called before the first frame update
    public static double CurrentMoney;
    public static double MoneyPerSecond;
    public TMP_Text MoneyDisplay;
    public TMP_Text MoneyPerSecondDisplay;
    public double InternalMoney;
    public double InternalMoneyPerSecond;
    public static List<HouseObject> HouseObjects = new List<HouseObject>();

    private void Start()
    {
        CurrentMoney = 0;
        MoneyPerSecond = 0;
        InvokeRepeating("AddMoneyPerSecondToCurrent", 1f, 1f);
    }

    void Update()
    {
        //Debug.Log(HouseObjects.Count().ToString());
        if(HouseObjects.Count > 0)
        {
            MoneyPerSecond = HouseObjects.Sum(x => x.Production);
        }
        InternalMoney = Math.Round(CurrentMoney, 2);
        InternalMoneyPerSecond = Math.Round(MoneyPerSecond, 2);
        MoneyDisplay.text = InternalMoney + "$";
        MoneyPerSecondDisplay.text = InternalMoneyPerSecond + "$/s";
    }

    void AddMoneyPerSecondToCurrent()
    {
        CurrentMoney += MoneyPerSecond;
    }

    public static bool CanBuy(double objectValue)
    {
        return CurrentMoney >= objectValue;
    }
}
