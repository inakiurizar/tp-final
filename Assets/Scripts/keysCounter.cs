using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCounter : MonoBehaviour
{
    public static int keycounter;
    public Text keys;

    void Start()
    {
        keycounter = 0;
    }
    // Update is called once per frame
    void Update()
    {
        keys.text = "Llaves : " + keycounter.ToString();
    }
}
