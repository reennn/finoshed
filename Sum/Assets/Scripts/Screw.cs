using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw : MonoBehaviour
{
    [SerializeField] float Smooth;
    [SerializeField] float Distance;

    bool State;
    float dist, normalDist;

    private void Start()
    {
        normalDist = transform.position.z;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, normalDist + dist), Smooth * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, dist*720), Smooth * Time.deltaTime);
    }
    public void UseBolt()
    {
        State = !State;
        if (State)
            dist = -Distance;
        else
            dist = 0;
    }
}
