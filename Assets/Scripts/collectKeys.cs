using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectKeys : MonoBehaviour
{
    public GameObject key;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            keyCounter.keycounter++;
            key.SetActive(false);
        }

    }


}
