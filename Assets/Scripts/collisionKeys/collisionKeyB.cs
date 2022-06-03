using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionKeyB : MonoBehaviour
{
    public GameObject player, keyB, keyG, keyO;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "llave(azul)")
        {
            keyCounter.blue_keycounter++;
            keyB.SetActive(false);
        }
        if (col.gameObject.name == "llave(verde)")
        {
            keyCounter.green_keycounter++;
            keyG.SetActive(false);
        }
        if (col.gameObject.name == "llave(naranja)")
        {
            keyCounter.orange_keycounter++;
            keyO.SetActive(false);
        }
    }
}
