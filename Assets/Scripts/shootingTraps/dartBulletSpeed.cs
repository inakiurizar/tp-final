using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartBulletSpeed : MonoBehaviour
{
    public float speed = 15f;
    public GameObject bala;
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "piso")
        {
            Destroy(bala);
        }
    }
}
