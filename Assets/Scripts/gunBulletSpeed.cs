using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunBulletSpeed : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
