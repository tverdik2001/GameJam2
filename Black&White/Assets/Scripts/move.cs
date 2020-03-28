using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.anyKey){

      if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.up * 7 * Time.deltaTime, Space.World);
        }
         if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += Vector3.down * speed * Time.deltaTime;
          }
        }
    }
}
