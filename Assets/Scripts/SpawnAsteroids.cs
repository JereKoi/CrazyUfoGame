using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
        StartCoroutine(speedup());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

    IEnumerator speedup()
    {
        while (true)
        {
            if (respawnTime >= 0.45f)
            {
                yield return new WaitForSeconds(25);
                respawnTime -= 0.1f;
            }
            else if (respawnTime <= 0.45f)
            {
                respawnTime = 0.45f;
            }
        }

        //while (true)
        //{
        //    yield return new WaitForSeconds(30);
        //    respawnTime -= 0.1f;
        //}
    }
}