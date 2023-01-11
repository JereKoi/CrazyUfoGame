using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;

    [SerializeField] private Renderer bgRenderer;

    private void Start()
    {
        //StartCoroutine(speedup());
    }

    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }

    //IEnumerator speedup()
    //{
    //    while (true)
    //    {
    //        if (speed <= 1.0f)
    //        {
    //            yield return new WaitForSeconds(2);
    //            speed += 0.01f;
    //        }
    //        else if (speed >= 1.0f)
    //        {
    //            speed = 1.0f;
    //        }
    //    }

        //while (true)
        //{
        //    yield return new WaitForSeconds(2);
        //    speed += 0.01f;
        //}
    //}
}
