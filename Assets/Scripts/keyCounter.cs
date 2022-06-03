using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCounter : MonoBehaviour
{
    public static int blue_keycounter, green_keycounter, orange_keycounter;

    public Text blue_key, green_key, orange_key;

    void Start()
    {
        blue_keycounter = 0;
        green_keycounter = 0;
        orange_keycounter = 0;
    }
    // Update is called once per frame
    void Update()
    {
        blue_key.text = "Llave azul: " + blue_keycounter.ToString();
        green_key.text = "Llave verde: " + green_keycounter.ToString();
        orange_key.text = "Llave naranja: " + orange_keycounter.ToString();
    }
}
