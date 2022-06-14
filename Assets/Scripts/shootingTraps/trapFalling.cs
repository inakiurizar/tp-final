using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapFalling : MonoBehaviour
{
    public GameObject block;
    GameObject clon;
    void Start()
    {
        StartCoroutine(blockFallRate());
    }
    IEnumerator blockFallRate()
    {
        while (true)
        {
            clon = Instantiate(block, transform.position, transform.rotation);
            yield return new WaitForSeconds(1);
        }
    }

    //float secDeltaTime;

    //void Update()
    //{
    //    secDeltaTime -= Time.deltaTime;
    //    if (secDeltaTime <= 0)
    //    {
    //        startPointFire();
    //        secDeltaTime++;
    //    }
    //}

    //public void startPointFire()
    //{
    //    clon = Instantiate(block, transform.position, transform.rotation);
    //}

}
