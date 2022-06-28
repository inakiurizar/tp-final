using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapGun : MonoBehaviour
{
    public GameObject bala;
    GameObject clon;
    public AUDIODEATH AUD;
    //public GameObject bullet;
    //float secDeltaTime;
    void Start()
    {
        StartCoroutine(fireRate());
    }
    IEnumerator fireRate()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {

            clon = Instantiate(bala, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.5f); 
            Destroy(clon, 5);
        }
    }
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
    //    GameObject clon;
    //    clon = Instantiate(bullet, transform.position, transform.rotation);
    //    Destroy(clon, 5);
    //}
}
