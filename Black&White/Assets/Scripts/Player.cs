using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   private bool isDead;
    private Rigidbody2D rb2d;
    public float upForce=200f;
    public float sp = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        isDead=false;
        rb2d=GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    { 
    //if(Input.anyKey){
      if (Input.GetKey(KeyCode.UpArrow)) {
       transform.Translate(Vector3.up * 7 * Time.deltaTime, Space.World);
      }
      if (Input.GetKey(KeyCode.DownArrow)) {
        transform.position += Vector3.down * sp * Time.deltaTime;
      }
      
     //}
    }

   
}
