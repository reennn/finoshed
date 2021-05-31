using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPickUP : MonoBehaviour
{
    GameObject TaskOnBoard;
    public GameObject Task1;
    public GameObject Task2;
    public GameObject Task3;
    public GameObject Task4;

    private void OnTriggerStay(Collider other)
    {
        TaskOnBoard = BoardPlayer.Instance.obj_1;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (TaskOnBoard.tag == "board")
            {
                Debug.Log("Выберете задание");
            }
            else
            {
                TaskOnBoard.SetActive(false);
            
                if (TaskOnBoard.tag == "task1")
                {
                    Task1.SetActive(true);
                    Debug.Log("Вы взяли 1-е задание");

                    if(Task2 == true)
                    {
                        Task2.SetActive(false);
                    }
                    if (Task3 == true)
                    {
                        Task3.SetActive(false);
                    }
                    if (Task4 == true)
                    {
                        Task4.SetActive(false);
                    }
                }

                if (TaskOnBoard.tag == "task2")
                {
                    Task2.SetActive(true);
                    Debug.Log("Вы взяли 2-е задание");
                    if (Task1 == true)
                    {
                        Task1.SetActive(false);
                    }
                    if (Task3 == true)
                    {
                        Task3.SetActive(false);
                    }
                    if (Task4 == true)
                    {
                        Task4.SetActive(false);
                    }
                }

                TaskOnBoard.SetActive(false);
                if (TaskOnBoard.tag == "task3")
                {
                    Task3.SetActive(true);
                    Debug.Log("Вы взяли 3-е задание");
                    if (Task1 == true)
                    {
                        Task1.SetActive(false);
                    }
                    if (Task2 == true)
                    {
                        Task2.SetActive(false);
                    }
                    if (Task4 == true)
                    {
                        Task4.SetActive(false);
                    }
                }

                TaskOnBoard.SetActive(false);
                if (TaskOnBoard.tag == "task4")
                {
                    Task4.SetActive(true);
                    Debug.Log("Вы взяли 4-е задание");
                    if (Task1 == true)
                    {
                        Task1.SetActive(false);
                    }
                    if (Task2 == true)
                    {
                        Task2.SetActive(false);
                    }
                    if (Task3 == true)
                    {
                        Task3.SetActive(false);
                    }
                }
            }
            
        }
    }
}

