using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UfoHealth : MonoBehaviour
{
    public GameObject[] hearts;
    public GameObject GameOver;
    public TMPro.TMP_Text ScoreText;
    private int life;
    private bool dead;

    public AdsManager ads;

    private void Start()
    {
        dead = false;
        Time.timeScale = 1;
        life = hearts.Length;
    }

    private void Update()
    {
        if (dead == true)
        {
            //ads.PlayAd();
            Time.timeScale = 0;
            GameOver.SetActive(true);
            ScoreText.enabled = false;
            //Game over
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            TakeDamage(1);
        }
    }
}
