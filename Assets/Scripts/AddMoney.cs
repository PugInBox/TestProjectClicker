using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AddMoney : MonoBehaviour
{
    public TextMeshProUGUI _moneyText;
    public Button _levelUpButton;
    public GameObject _banknote;
    private GameObject _newBanknote;
    public float _force = 10f;
    // public void OnMouseDown()
    // {
    //         GlobalVar._moneyTotal += GlobalVar._moneyAdd;
    //         GlobalVar._hasChanged = true;
    //         _newBanknote = Instantiate(_banknote, new Vector2(0, 0), Quaternion.identity) as GameObject;
    //         _newBanknote.transform.SetParent(_banknote.transform.parent);
    //         _newBanknote.gameObject.SetActive(true);
    //         _newBanknote.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1.5f, 1.5f), 7f), ForceMode2D.Impulse);
    //         _newBanknote.gameObject.GetComponent<Transform>().Rotate(new Vector2(Random.Range(0, 50f), Random.Range(0, 50f)), Random.Range(0, 50f));
    //         Destroy(_newBanknote, 4f);
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
                    GlobalVar._moneyTotal += GlobalVar._moneyAdd;
                    GlobalVar._hasChanged = true;
                    _newBanknote = Instantiate(_banknote, new Vector2(0, 0), Quaternion.identity) as GameObject;
                    _newBanknote.transform.SetParent(_banknote.transform.parent);
                    _newBanknote.gameObject.SetActive(true);
                    _newBanknote.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1.5f, 1.5f), 7f), ForceMode2D.Impulse);
                    _newBanknote.gameObject.GetComponent<Transform>().Rotate(new Vector2(Random.Range(0, 50f), Random.Range(0, 50f)), Random.Range(0, 50f));
                    Destroy(_newBanknote, 4f);
                }
                if (GlobalVar._moneyTotal < GlobalVar._lvlUpgradeCost)
                {
                    _levelUpButton.interactable = false;
                }
                else
                {
                    _levelUpButton.interactable = true;
                }
            }
        }
        transform.Find("MoneyAddText").gameObject.GetComponent<TextMeshProUGUI>().text = "+" + GlobalVar._moneyAdd;
    }
}
