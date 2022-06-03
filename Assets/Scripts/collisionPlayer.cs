using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class collisionPlayer : MonoBehaviour
{
    Vector3 startPosition;
    public static int hearts = 3;
    public int vida = 100;
    public Text corazones, gameOver, vidatxt;
    public GameObject player, camara, keysText, restartScene, pared;
    int danioDardo = 20;

    void Start()
    {
        startPosition = transform.position;
        gameOver.enabled = false;
        camara.SetActive(false);
        restartScene.SetActive(false);
        //StartCoroutine(ExampleCoroutine());

    }

    void Update()
    {
        corazones.text = hearts.ToString();
        vidatxt.text = vida.ToString();
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(0, 1, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            hearts--;
            vida--;
            SceneManager.LoadScene("SampleScene");
        }
        if(vida <= 0)
        {
            hearts--;
            vida += 100;
            transform.position = startPosition;
            transform.eulerAngles = new Vector3(0, 0, 0);
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
            vidatxt.enabled = false;
        }

        if (collision.gameObject.name == "bala(Clone)")
        {
            //transform.position = startPosition;
            //transform.eulerAngles = new Vector3(0, 0, 0);
            vida -= 50;
            //SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.name == "placapresion")
        {
            StartCoroutine(paredTimer());
        }
        if (collision.gameObject.name == "dardo(Clone)")
        {
            StartCoroutine(dardoTimer());
        }
    }

    IEnumerator paredTimer()
    {
        while (true)
        {
            pared.SetActive(false);
            yield return new WaitForSeconds(3);
            pared.SetActive(true);
        }
    }
    IEnumerator dardoTimer()
    {
        int i = 0;
        while (danioDardo > i)
        {
            vida--;
            yield return new WaitForSeconds(1);
            i++;
        }

    }


}
