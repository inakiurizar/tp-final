using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    float mouseSens = 0.2f;
    public Transform player;
    float xRotation = 0f;
    float mouseX, mouseY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * mouseSens;
        mouseY += Input.GetAxis("Mouse Y") * mouseSens;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90);

        transform.localRotation = Quaternion.Euler(xRotation,0,0);
        player.Rotate(Vector3.up * mouseX);
    }
}
