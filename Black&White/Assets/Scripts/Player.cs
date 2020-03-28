using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isDead;
    private Rigidbody2D rb2d;
    public float upForce=200f;
    // Start is called before the first frame update
    void Start()
    {
        isDead=false;
        rb2d=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDead){
            if(Input.GetMouseButtonDown(0)){
                rb2d.velocity=Vector2.zero;
                rb2d.AddForce(new Vector2(0,upForce));

            }
        }
    }

    void OnCollisionEnter2D(){
        isDead=true;
        GameControl.instance1.ghostDied();
    }
}
