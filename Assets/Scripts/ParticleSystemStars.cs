using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ParticleSystemStars : MonoBehaviour
{
    public float speed = 1f;
    ParticleSystem stars;

    private void Start()
    {
        stars = GetComponent<ParticleSystem>() as ParticleSystem;
        StartCoroutine(speedup());
    }

    [System.Obsolete]
    private void Update()
    {
        stars.playbackSpeed = speed;
    }
    IEnumerator speedup()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            speed += 0.01f;
        }
    }
}
