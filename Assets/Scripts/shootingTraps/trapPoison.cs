using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapPoison : MonoBehaviour
{
    public GameObject dardo;
    float sec = 1f;
    float secDeltaTime;

    void Update()
    {
        secDeltaTime -= Time.deltaTime;
        if (secDeltaTime <= 0)
        {
            startPointFire();
            secDeltaTime += sec;
        }
    }

    public void startPointFire()
    {
        GameObject clon;
        clon = Instantiate(dardo, transform.position, transform.rotation);
        Destroy(clon, 5);
    }
}
