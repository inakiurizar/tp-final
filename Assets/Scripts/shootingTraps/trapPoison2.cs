using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapPoison2 : MonoBehaviour
{
    public GameObject dardo;
    GameObject clon;
    void Start()
    {
        StartCoroutine(fireRate());
    }
    IEnumerator fireRate()
    {
        yield return new WaitForSeconds(1.25f);
        while (true)
        {

            clon = Instantiate(dardo, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.5f);
            Destroy(clon, 5);
        }
    }

}
