using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamButton : MonoBehaviour
{
    private int countButton = 1;
    public GameObject steam_obj;
    public GameObject button_obj;
    public GameObject close_obj;

    public Material buttonEnabled;
    public Material buttonUnenabled;

    void Awake()
    {
        steam_obj.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            steam_obj.SetActive(true);
            countButton += 1;

            if (countButton % 2 == 0)
            {
                button_obj.GetComponent<Renderer>().material = buttonEnabled;
                close_obj.SetActive(false);
                Debug.Log("Люк открыт!");
            }
            else
            {
                button_obj.GetComponent<Renderer>().material = buttonUnenabled;
                steam_obj.SetActive(false);
                close_obj.SetActive(true);
                Debug.Log("Люк закрыт!");
            }
        }
    }
}
