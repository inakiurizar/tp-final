using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpeed : MonoBehaviour
{
    public float speed = 10f;
    public GameObject clon;

    void Update()
    {
        transform.Translate(0, -(speed * Time.deltaTime), 0);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube (1)")
        {
            Destroy(clon);
        }
    }
}
