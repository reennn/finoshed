using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForDirt : MonoBehaviour
{

    public GameObject dirt;

    private void Awake()
    {
        dirt.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) && other.tag == "Player")
        {
            dirt.SetActive(false);
            Debug.Log("Успешно почищено");
        }
    }

}
