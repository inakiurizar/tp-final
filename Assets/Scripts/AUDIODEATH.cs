using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUDIODEATH : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;

    public void playClip()
    {
        source.clip = clip;
        source.Play();
    }
}
