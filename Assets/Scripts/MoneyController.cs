using System.Collections;
using System.Collections.Generic;
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

    private void Start()
    {
        CurrentMoney = 0;
        MoneyPerSecond = 0;
    }

    void Update()
    {
        InternalMoney = CurrentMoney;
        InternalMoneyPerSecond = MoneyPerSecond;
        MoneyDisplay.text = InternalMoney + "$";
        MoneyPerSecondDisplay.text = InternalMoneyPerSecond + "$/s";
    }

    public static bool CanBuy(double objectValue)
    {
        return CurrentMoney >= objectValue;
    }
}
