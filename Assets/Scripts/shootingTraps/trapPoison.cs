using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapPoison : MonoBehaviour
{
    public GameObject dardo;
    GameObject clon;
    void Start()
    {
        StartCoroutine(fireRate());    
    }
    void Update()
    {
        //secDeltaTime -= Time.deltaTime;
        //if (secDeltaTime <= 0)
        //{
        //    startPointFire();
        //    secDeltaTime += sec;
        //}
    }
    IEnumerator fireRate()
    {
        while (true)
        {
            clon = Instantiate(dardo, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.5f);
            Destroy(clon, 5);
        }
    }



    //public void startPointFire()
    //{
    //    GameObject clon;
    //    clon = Instantiate(dardo, transform.position, transform.rotation);
    //    Destroy(clon, 5);
    //}
}
