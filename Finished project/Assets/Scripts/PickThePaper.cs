using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickThePaper : MonoBehaviour
{
    private int NumberOfPaper;

    GameObject PickedObj;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    const int paper1 = 1;
    const int paper2 = 2;
    const int paper3 = 3;
    const int paper4 = 4;

    private void OnTriggerStay(Collider other)
    {
        PickedObj = TaskPlayer.Instance.PickedObj;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (PickedObj.tag == "table" || PickedObj.tag == "floor")
            {
                Debug.Log("Выберете лист");
            }
            else
            {
                if (PickedObj.tag == "paper1")
                {
                    NumberOfPaper = 1;
                }

                if (PickedObj.tag == "paper2")
                {
                    NumberOfPaper = 2;
                }

                if (PickedObj.tag == "paper3")
                {
                    NumberOfPaper = 3;
                }

                if (PickedObj.tag == "paper4")
                {
                    NumberOfPaper = 4;

                }
            }

            switch (NumberOfPaper)
            {
                case paper1:

                    if (p2 == true)
                    {
                        p2.SetActive(false);
                    }

                    if (p3 == true)
                    {
                        p3.SetActive(false);
                    }

                    if (p4 == true)
                    {
                        p4.SetActive(false);
                    }

                    PickedObj.SetActive(false);
                    p1.SetActive(true);
                    Debug.Log("Выбран " + NumberOfPaper.ToString() + "-й лист!");

                    break;

                case paper2:

                    if (p1 == true)
                    {
                        p1.SetActive(false);
                    }

                    if (p3 == true)
                    {
                        p3.SetActive(false);
                    }

                    if (p4 == true)
                    {
                        p4.SetActive(false);
                    }

                    PickedObj.SetActive(false);
                    p2.SetActive(true);
                    Debug.Log("Выбран " + NumberOfPaper.ToString() + "-й лист!");

                    break;

                case paper3:

                    if (p1 == true)
                    {
                        p1.SetActive(false);
                    }

                    if (p2 == true)
                    {
                        p2.SetActive(false);
                    }

                    if (p4 == true)
                    {
                        p4.SetActive(false);
                    }

                    PickedObj.SetActive(false);
                    p3.SetActive(true);
                    Debug.Log("Выбран " + NumberOfPaper.ToString() + "-й лист!");

                    break;

                case paper4:

                    if (p1 == true)
                    {
                        p1.SetActive(false);
                    }

                    if (p2 == true)
                    {
                        p2.SetActive(false);
                    }

                    if (p3 == true)
                    {
                        p3.SetActive(false);
                    }

                    PickedObj.SetActive(false);
                    p4.SetActive(true);
                    Debug.Log("Выбран " + NumberOfPaper.ToString() + "-й лист!");

                    break;
            }
        }
    }
}

