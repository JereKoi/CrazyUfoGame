using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public TMP_Text phaseDisplayText;
    private Touch theTouch;

    //Character movement
    public float characterSpeed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            if (theTouch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x + theTouch.deltaPosition.x * characterSpeed,
                    transform.position.y + theTouch.deltaPosition.y * characterSpeed);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "offscreen")
        {
            characterSpeed = 0f;
        }
        else
        {
            characterSpeed = 1f;
        }
    }
}