using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openingDoors : MonoBehaviour
{
    public GameObject player, placaB, placaG, placaO, paredB, paredG, paredO;

    void Start()
    {
        StartCoroutine(paredBlue());
        StartCoroutine(paredGreen());
        StartCoroutine(paredOrange());
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "placapresionAzul" && keyCounter.blue_keycounter == 1)
        {
            paredB.SetActive(false);
        }
        if(col.gameObject.name == "placapresionVerde" && keyCounter.green_keycounter == 1)
        {
            paredG.SetActive(false);
        }
        if(col.gameObject.name == "placapresionNaranja" && keyCounter.orange_keycounter == 1)
        {
            paredO.SetActive(false);
        }
    }
    IEnumerator paredBlue()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            paredB.SetActive(true);
        }
    }
    IEnumerator paredGreen()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            paredG.SetActive(true);
        }
    }
    IEnumerator paredOrange()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            paredO.SetActive(true);
        }
    }
}
