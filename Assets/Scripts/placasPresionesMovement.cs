using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placasPresionesMovement : MonoBehaviour
{

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            placaB.transform.position = new Vector3(-10.02f, -0.06f, 1.6f);
        }
        if (col.gameObject.name == "Player")
        {
            placaG.transform.position = new Vector3(-10.02f, -0.06f, -4.55f);
        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            transform.position = new Vector3(-10.02f, 0, 1.6f);
        }
        if (col.gameObject.name == "Player")
        {
            placaG.transform.position = new Vector3(-10.02f, 0, -4.55f);
        }
    }
}
