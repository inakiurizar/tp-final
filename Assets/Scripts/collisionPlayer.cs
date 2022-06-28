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
    public Text corazones, gameOver, vidatxt, ganaste, TIEMPO, TUTIEMPOFUEDE;
    public GameObject player, camara, keyBlue, keyGreen, keyOrange, restartScene, pared;
    int danioDardo = 20;
    bool isHit = true;
    int counter = 0;
    public AudioSource MUSICAFONDO;

    void Start()
    {
        startPosition = transform.position;
        gameOver.enabled = false;
        ganaste.enabled = false;
        camara.SetActive(false);
        restartScene.SetActive(false);
        StartCoroutine(paredTimerAct());
    }

    void Update()
    {
        TIEMPO.text = Mathf.Floor(Time.time).ToString();

        corazones.text = hearts.ToString();
        vidatxt.text = vida.ToString();
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(0, 1, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            hearts--;
            vida--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(vida <= 0)
        {
            //TIEMPO.text == 0.ToString();
            //hearts--;
            //vida += 100;
            //transform.position = startPosition;
            //transform.eulerAngles = new Vector3(0, 0, 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "mapaJuego")
        {
            Debug.Log("ITS WORKING");
            if (collision.gameObject.tag == "obstacle")
            {
                transform.position = startPosition;
                transform.eulerAngles = new Vector3(0, 0, 0);
                hearts--;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            if (hearts == 0)
            {
                player.SetActive(false);
                gameOver.enabled = true;
                camara.SetActive(true);
                corazones.enabled = false;
                restartScene.SetActive(true);
                vidatxt.enabled = false;
                MUSICAFONDO.enabled = false;
            }

            if (collision.gameObject.name == "bala(Clone)" && isHit)
            {
                vida -= 50;
                isHit = false;
                StartCoroutine(ishit());
            }
            if (collision.gameObject.name == "placapresion")
            {
                pared.SetActive(false);
            }
            if (collision.gameObject.name == "dardo(Clone)")
            {
                StartCoroutine(dardoTimer());
                counter++;
            }
            if (collision.gameObject.name == "block(Clone)")
            {
                transform.position = startPosition;
                transform.eulerAngles = new Vector3(0, 0, 0);
                hearts--;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            if (collision.gameObject.name == "placapresionVerde" && keyCounter.green_keycounter == 1)
            {
                player.SetActive(false);
                camara.SetActive(true);
                corazones.enabled = false;
                keyBlue.SetActive(false);
                keyGreen.SetActive(false);
                keyOrange.SetActive(false);
                restartScene.SetActive(true);
                vidatxt.enabled = false;
                ganaste.enabled = true;
                MUSICAFONDO.enabled = false;
            }
        }
    }
    IEnumerator dardoTimer()
    {
        int i = 0;
        if(counter > 1)
        {
            danioDardo *= counter;
        }
        while (danioDardo > i)
        {
            vida--;
            yield return new WaitForSeconds(1);
            i++;
        }
    }
    IEnumerator ishit()
    {
        if(isHit == false)
        {
            yield return new WaitForSeconds(3);
            isHit = true;
        }
    }
    IEnumerator paredTimerAct()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            pared.SetActive(true);
        }
    }


}
