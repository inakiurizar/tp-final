using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartBulletSpeed : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
