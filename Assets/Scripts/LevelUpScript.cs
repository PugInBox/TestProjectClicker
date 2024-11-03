using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelUpScript : MonoBehaviour
{
    public TextMeshProUGUI _levelCounter;
    public
    // void OnMouseDown()
    // {
    //         if (GlobalVar._moneyTotal > GlobalVar._lvlUpgradeCost)
    //         {
    //             GlobalVar._moneyTotal -= GlobalVar._lvlUpgradeCost;
    //             GlobalVar._lvlUpgradeCost *= GlobalVar._lvlUpgradeMultiply;
    //             GlobalVar._moneyAdd++;
    //             GlobalVar._showLevel++;
    //             _levelCounter.gameObject.GetComponent<TextMeshProUGUI>().text = "LV: " + GlobalVar._showLevel;
    //             transform.Find("UpgradeText").gameObject.GetComponent<TextMeshProUGUI>().text = "Upgrade: " + GlobalVar._lvlUpgradeCost;
    //             GlobalVar._hasChanged = true;
    //         }
    // }
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            foreach (Touch touch in Input.touches)
            {
                int id = touch.fingerId;
                if (EventSystem.current.IsPointerOverGameObject(id))
                {
                    if (GlobalVar._moneyTotal > GlobalVar._lvlUpgradeCost)
                    {
                        GlobalVar._moneyTotal -= GlobalVar._lvlUpgradeCost;
                        GlobalVar._lvlUpgradeCost *= GlobalVar._lvlUpgradeMultiply;
                        GlobalVar._moneyAdd++;
                        GlobalVar._showLevel++;
                        _levelCounter.gameObject.GetComponent<TextMeshProUGUI>().text = "LV: " + GlobalVar._showLevel;
                        transform.Find("UpgradeText").gameObject.GetComponent<TextMeshProUGUI>().text = "Upgrade: " + GlobalVar._lvlUpgradeCost;
                        GlobalVar._hasChanged = true;
                    }
                }
            }

        }
    }
}
