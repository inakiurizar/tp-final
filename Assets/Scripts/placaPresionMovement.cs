using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placaPresionMovement : MonoBehaviour
{
    public GameObject pared;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            transform.position = new Vector3(3.5f, -0.06f, 8.3f);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            transform.position = new Vector3(3.5f, 0, 8.3f);
        }
    }
}
