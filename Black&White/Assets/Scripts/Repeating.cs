using UnityEngine;
using System.Collections;

public class Repeating: MonoBehaviour 
{   
    private float groundHorizontalLength;       

    private void Awake ()
    {
        groundHorizontalLength = 24f;
    }

    private void Update()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2) transform.position + groundOffSet;
    }
}