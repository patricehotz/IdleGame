using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    public GameObject BuyButton;

    private void Start()
    {
        BuyButton.SetActive(false);
    }
    public void OnMouseDown()
    {
        BuyButton.SetActive(!BuyButton.activeSelf);
    }
}
