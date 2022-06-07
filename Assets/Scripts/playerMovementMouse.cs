using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementMouse : MonoBehaviour
{
    public float sensibilidad = 100f;
    public Transform player;
    float xRotation = 0f;
    float mouseX, mouseY;
    float yRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X")*sensibilidad;
        mouseY += Input.GetAxis("Mouse Y")*sensibilidad;

        xRotation -= mouseY;
        yRotation += mouseX;
        xRotation -= Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.Rotate(Vector3.up * yRotation);
    }
}
