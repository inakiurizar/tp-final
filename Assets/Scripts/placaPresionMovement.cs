using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placaPresionMovement : MonoBehaviour
{
    //public GameObject pared;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            transform.position = new Vector3(5.42f, -0.14f, 1.6f);
            //Destroy(pared, 0);
        }
    }

    //void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.name == "Player")
    //    {
    //        transform.position = new Vector3(5.42f, 0, 1.6f);
    //    }
    //}
}
