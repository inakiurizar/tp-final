using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunBulletSpeed : MonoBehaviour
{
    public float speed = 6f;
    public GameObject bala;
    GameObject clon;

    void Update()
    {
        clon = bala;
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            Destroy(clon);
        }
    }
}
