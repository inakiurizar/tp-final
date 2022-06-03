using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapGun : MonoBehaviour
{
    public GameObject bullet;
    float secDeltaTime;

    void Update()
    {
        secDeltaTime -= Time.deltaTime;
        if (secDeltaTime <= 0)
        {
            startPointFire();
            secDeltaTime++;
        }
    }

    public void startPointFire()
    {
        GameObject clon;
        clon = Instantiate(bullet, transform.position, transform.rotation);
        Destroy(clon, 5);
    }
}
