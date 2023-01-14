using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TMPro.TMP_Text scoreText;
    public TMPro.TMP_Text gameOverText;
    private float score = 0f;

    private void Start()
    {
        score = 0f;
        scoreText.SetText(score.ToString() + "m");
        gameOverText.SetText("Your score: " + score.ToString() + "m");
        StartCoroutine(Score());
    }

    IEnumerator Score()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            score++;
            scoreText.SetText(score.ToString() + "m");
            gameOverText.SetText("Your score: " + score.ToString() + "m");
        }
    }
}
