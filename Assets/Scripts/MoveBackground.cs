using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private Transform centerBackground;

    private void Update()
    {
        if (transform.position.x >= centerBackground.position.x + 40.96f)
        {
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y + 40.96f);
        }

        else if(transform.position.x >= centerBackground.position.x + 40.96f)
        {
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y - 40.96f);
        }
    }
}
