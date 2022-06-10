using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restartScene : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            collisionPlayer.hearts = 3;
            Debug.Log("Working just fine");
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void restartActivo()
    {

    }
}
