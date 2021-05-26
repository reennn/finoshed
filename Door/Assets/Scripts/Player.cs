using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform Eye;

    [SerializeField] float Sensitivity = 3;

    [SerializeField] float FastSpeed = 8;
    [SerializeField] float NormalSpeed = 3;
    [SerializeField] float SlowSpeed = 1;

    [SerializeField] float JumpSpeed = 5;

    [SerializeField] KeyCode RunButton = KeyCode.LeftShift;
    [SerializeField] KeyCode SlowButton = KeyCode.LeftControl;

    [SerializeField] KeyCode JumpButton = KeyCode.Space;

    int hor, ver;
    float rotX, rotY, speed, jSpeed, distance;
    CharacterController chCtrl;
    Vector3 direction;

    GameObject obj_1;
    GameObject obj_2;

    bool CanTake = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ruler")
        {
            CanTake = true;
        }
    }

    private void Start()
    {
        chCtrl = transform.GetComponent<CharacterController>();
        rotX = transform.rotation.eulerAngles.y;
        rotY = transform.rotation.eulerAngles.x;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (!Cursor.visible)
        {
            ver = hor = 0;
            if (Input.GetKey(KeyCode.W))
                ver++;
            if (Input.GetKey(KeyCode.S))
                ver--;
            if (Input.GetKey(KeyCode.D))
                hor++;
            if (Input.GetKey(KeyCode.A))
                hor--;

            if (Input.GetKey(JumpButton) && chCtrl.isGrounded)
                jSpeed = JumpSpeed;

            rotX -= Input.GetAxis("Mouse Y") * Sensitivity;
            rotX = Mathf.Clamp(rotX, -90, 90);
            rotY += Input.GetAxis("Mouse X") * Sensitivity;
        }
        else
            hor = ver;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        speed = NormalSpeed;
        if (Input.GetKey(SlowButton))
            speed = SlowSpeed;
        if (Input.GetKey(RunButton))
            speed = FastSpeed;

        if (!chCtrl.isGrounded)
            jSpeed += Physics.gravity.y * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0, rotY, 0);
        Eye.localRotation = Quaternion.Euler(rotX, 0, 0);

        direction = Vector3.Normalize(transform.forward * ver + transform.right * hor);

        chCtrl.Move((direction * speed + transform.up * jSpeed) * Time.deltaTime);



        // Builds a ray from camera point of view to the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.Mouse0) && CanTake == true)
        {
            if (Physics.Raycast(ray, out hit))
            {
                obj_1 = hit.transform.gameObject;
                //anim.SetBool("Clicked", true);
                Debug.Log("1-ый объект выбран");
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && CanTake == true)
        {
            if (Physics.Raycast(ray, out hit))
            {
                obj_2 = hit.transform.gameObject;
                //anim.SetBool("Clicked", true);
                Debug.Log("2-ой объект выбран");
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            distance = Vector3.Distance(obj_1.transform.position, obj_2.transform.position);
            Debug.Log("Дистанция между объектами: " + distance.ToString("F2"));
        }
    }

}
