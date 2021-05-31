using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLVL : MonoBehaviour
{
    public int NextLvlToLoad;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene(NextLvlToLoad);
            Debug.Log("Next scene");
        }
    }
}
