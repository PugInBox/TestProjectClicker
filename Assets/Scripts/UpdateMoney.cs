using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateMoney : MonoBehaviour
{
    void Update()
    {
        if (GlobalVar._hasChanged){
            GetComponent<TextMeshProUGUI>().text = "Money: " + GlobalVar._moneyTotal;
            GlobalVar._hasChanged = false;
        }
    }
}
