using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	public float smooth = 2.0f;
	public float DoorOpenAngle = 90.0f;

	private Vector3 defaultRot;
	private Vector3 openRot;
	private bool open;
	private bool enter;
	private int count = 0;

	void Start ()
	{
		
		defaultRot = transform.eulerAngles;
		openRot = new Vector3 (defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.F) && enter)
		{
			open = !open;
			if (count % 2 == 0)
            {
				Debug.Log("Дверь открыта");
				count += 1;
			}

            else
            {
				Debug.Log("Дверь закрыта");
				count += 1;
			}

		}
		if (open)
		{
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
			
		}
		else
		{
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") 
		{
			enter = true;
		}
	}

    void OnTriggerExit(Collider col)
{
	if (col.tag == "Player") 
		{
		enter = false;
		}
	}
}