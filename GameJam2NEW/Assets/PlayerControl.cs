using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
   

   
   
    Rigidbody rigidbody;
    MeshRenderer renderer;

    public bool remote = false;

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        rigidbody = GetComponent<Rigidbody>();
        mouseCurLocation = new Vector3(Input.mousePosition.x, 0.5f, Input.mousePosition.y);
        mousePreviousLocation = mouseCurLocation;
        //Cursor.visible = false;
        renderer = GetComponent<MeshRenderer>();
    }



    
    public Vector3 mousePreviousLocation;
    public Vector3 mouseCurLocation;
    public Vector3 force;
    public Vector3 objectCurrentPosition;
    public Vector3 objectTargetPosition;
    public float topSpeed = 5;

    Color currentColor = Color.black;

    void FixedUpdate()
    {

        if (remote)
        {
            mouseCurLocation = new Vector3(Input.mousePosition.x, 0.5f, Input.mousePosition.y);
            force = mouseCurLocation - mousePreviousLocation;
        }
        else
        {
            force = new Vector3(Input.GetAxis("Mouse X") * topSpeed, 0.5f, Input.GetAxis("Mouse Y") * topSpeed);
        }
        mousePreviousLocation = mouseCurLocation;

        if (rigidbody.velocity.magnitude > topSpeed)
            force = rigidbody.velocity.normalized * topSpeed;
        
       
        rigidbody.velocity = new Vector3(-force.x, 0, -force.z);
        
        mousePreviousLocation = new Vector3(Input.mousePosition.x, 0.5f, Input.mousePosition.y);
      

        if (Input.GetMouseButtonDown(0))
        {
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        if (currentColor == Color.black)
            currentColor = Color.white;
        else
            currentColor = Color.black;

        renderer.material.color = currentColor;
    }


}
