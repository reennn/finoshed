using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] Transform ButtonTransform;
    [SerializeField] float AngleRotation = 25;
    [SerializeField] float Smooth = 50;
    [Space]
    [SerializeField] AudioSource Source;
    [SerializeField] AudioClip InteractionAudio;
    
    public bool StartSignal;
    [HideInInspector]
    public bool PossibilityOfPressing, Signal;

    float angle;

    private void Start()
    {
        Signal = StartSignal;
        if (Signal)
            angle = AngleRotation;
    }
    private void Update()
    {
        ButtonTransform.localRotation = Quaternion.Lerp(ButtonTransform.localRotation, Quaternion.Euler(0, 0, -angle), Smooth * Time.deltaTime);
    }
    public void UseButton()
    {
        Signal = !Signal;
        if (Signal)
            angle = AngleRotation;
        else
            angle = 0;
        Source.PlayOneShot(InteractionAudio);

        //if (PossibilityOfPressing)
        //{
        //    Signal = !Signal;
        //    if (Signal)
        //        angle = AngleRotation;
        //    else
        //        angle = 0;
        //    Source.PlayOneShot(InteractionAudio);
        //    PossibilityOfPressing = false;
        //}
    }
}
