using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActive : MonoBehaviour
{
    public GameObject fuel;

    private void Awake()
    {
        fuel.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    { 
        if (Input.GetKeyDown(KeyCode.F) && other.tag == "Player")
        { 
            fuel.SetActive(true);
            Debug.Log("Смазка была нанесена");
        }
    }
}
