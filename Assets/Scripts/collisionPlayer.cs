using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class collisionPlayer : MonoBehaviour
{
    Vector3 startPosition;
    public static int hearts = 3;
    public Text corazones, gameOver;
    public GameObject player, camara, keysText, restartScene, pared;

    void Start()
    {
        startPosition = transform.position;
        gameOver.enabled = false;
        camara.SetActive(false);
        restartScene.SetActive(false);
        StartCoroutine(ExampleCoroutine());
    }

    void Update()
    {
        corazones.text = hearts.ToString();
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(0, 1, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            hearts--;
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstacle")
        {
            transform.position = startPosition;
            transform.eulerAngles = new Vector3(0, 0, 0);
            hearts--;
            SceneManager.LoadScene("SampleScene");
        }

        if (hearts == 0)
        {
            player.SetActive(false);
            gameOver.enabled = true;
            camara.SetActive(true);
            corazones.enabled = false;
            keysText.SetActive(false);
            restartScene.SetActive(true);
        }

        if (collision.gameObject.name == "bala(Clone)")
        {
            transform.position = startPosition;
            transform.eulerAngles = new Vector3(0, 0, 0);
            hearts--;
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.name == "placapresion")
        {
            pared.SetActive(false);
        }
    }
    IEnumerator ExampleCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            pared.SetActive(true);
        }
    }


}
