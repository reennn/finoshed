using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickTrigger : MonoBehaviour
{
    private int CountClick = 1;
    public Animator anim;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        { 
            CountClick += 1;

            if(CountClick % 2 == 0)
            {
                anim.SetBool("IsUsed", true);
            }
            else
            {
                anim.SetBool("IsUsed", false);
            }
        }
    }
}
