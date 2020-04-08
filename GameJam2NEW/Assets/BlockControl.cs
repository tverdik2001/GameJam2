using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour
{

    public enum DirectionX { none, left, right}
    public enum DirectionY { none, up, down}


    public float speed = 0.2f;
    public float offsetX = 1;
    public float offsetY = 2;

    public DirectionX directionX;
    public DirectionY directionY;

    float startX;
    float startY;
    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (directionY != DirectionY.none)
        {
            Vector3 target = transform.position;
            if (directionY== DirectionY.up)
            {
                target = new Vector3(transform.position.x, transform.position.y, startY + offsetY);
                if (Vector3.Distance(transform.position, target) < 0.1f)
                {
                    directionY = DirectionY.down;
                }
            }
            else
            if (directionY == DirectionY.down)
            {
                target = new Vector3(transform.position.x, transform.position.y, startY - offsetY);
                if (Vector3.Distance(transform.position, target) < 0.1f)
                {
                    directionY = DirectionY.up;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);           
        }

        if (directionX != DirectionX.none)
        {
            Vector3 target = transform.position;
            if (directionX == DirectionX.left)
            {
                target = new Vector3(startX - offsetX, transform.position.y, transform.position.z);
                if (Vector3.Distance(transform.position, target) < 0.1f)
                {
                    directionX = DirectionX.right;
                }
            }
            else
            if (directionX == DirectionX.right)
            {
                target = new Vector3(startX + offsetX, transform.position.y, transform.position.z);
                if (Vector3.Distance(transform.position, target) < 0.1f)
                {
                    directionX = DirectionX.left;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
    }
}
