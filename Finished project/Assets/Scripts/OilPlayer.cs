using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilPlayer : MonoBehaviour
{
    [SerializeField] Transform Eye;

    [SerializeField] float Sensitivity = 3;

    [SerializeField] float FastSpeed = 8;
    [SerializeField] float NormalSpeed = 3;
    [SerializeField] float SlowSpeed = 1;

    [SerializeField] float JumpSpeed = 5;

    [SerializeField] KeyCode RunButton = KeyCode.LeftShift;
    [SerializeField] KeyCode SlowButton = KeyCode.LeftControl;

    KeyCode JumpButton = KeyCode.Space;

    int hor, ver;
    float rotX, rotY, speed, jSpeed;
    CharacterController chCtrl;
    Vector3 direction;


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
    }
}
