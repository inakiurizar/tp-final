using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartBulletSpeed : MonoBehaviour
{
    public float speed = 15f;
    public GameObject bala;
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

}
