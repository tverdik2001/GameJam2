using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float Sensitivity = 10;
    Vector3 pos;

    public float h;
    public float v;

    Rigidbody rb;
    private Vector3 screenPoint;
    private Vector3 offset;

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }


    float horizontalSpeed = 0.05f;
    float verticalSpeed = 0.05f;

    void Update()
    {


        // Get the mouse delta. This is not in the range -1...1
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");

       transform.Translate(-h, 0, -v);
      
        //screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);





        //Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);


        //Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        //Debug.Log(curScreenPoint + );
        //transform.position = new Vector3(-curPosition.x,curPosition.y, -curPosition.z);
        //offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(
        //   new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }


    void OnMouseDrag()
    {
       

    }

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    //Cursor.lockState = CursorLockMode.Locked;
    //}

    //float mDelta = 0; // Pixels. The width border at the edge in which the movement work
    //float mSpeed = 3.0f; // Scale. Speed of the movement

    //// Update is called once per frame
    //void Update()
    //{

    //    //if (Input.mousePosition.x >= Screen.width - mDelta)
    //    //{
    //    //    // Move the camera
    //    //    transform.position += transform.right * Time.deltaTime * mSpeed;
    //    //}


    //    //if (Input.mousePosition.x <= 0 + mDelta)
    //    //{
    //    //    // Move the camera
    //    //    transform.position -= transform.right * Time.deltaTime * mSpeed;
    //    //}


    //    //if (Input.mousePosition.y >= Screen.height - mDelta)
    //    //{
    //    //    // Move the camera
    //    //    transform.position += transform.up * Time.deltaTime * mSpeed;
    //    //}

    //    //if (Input.mousePosition.y <= 0 + mDelta)
    //    //{
    //    //    // Move the camera
    //    //    transform.position -= transform.up * Time.deltaTime * mSpeed;
    //    //}


    //    //Cursor.lockState = CursorLockMode.None;
    //    //if (Cursor.lockState == CursorLockMode.Confined)
    //    //    Cursor.lockState = CursorLockMode.Locked;
    //    //else
    //    //    Cursor.lockState = CursorLockMode.Confined;
    //    //if (Input.mousePosition.x - pos.x > 0)
    //    //{
    //    //    h = 1;

    //    //}
    //    //else
    //    //if (Input.mousePosition.x - pos.x < 0)
    //    //{
    //    //    h = -1;

    //    //}
    //    //else
    //    //    h = 0;
    //    //if (Input.mousePosition.y - pos.y > 0)
    //    //{
    //    //    v = 1;

    //    //}
    //    //else
    //    //if (Input.mousePosition.y - pos.y < 0)
    //    //{
    //    //    v = -1;

    //    //}
    //    //else
    //    //    v = 0;
    //    h = 0;
    //    if (Input.GetAxis("Mouse X") > 0)
    //        h = 1;

    //    if (Input.GetAxis("Mouse X") < 0)
    //        h = -1;

    //    v = 0;

    //    if (Input.GetAxis("Mouse Y") > 0)
    //        v = 1;

    //    if (Input.GetAxis("Mouse Y") < 0)
    //        v = -1;



    //      Debug.Log("h - " + h + ", v - " + v);



    //    transform.Translate(new Vector3((h) * Sensitivity, 0, (v) * Sensitivity));

    //    //pos = Input.mousePosition;


    //    //rb.AddForce(h * Sensitivity, 0, v * Sensitivity);
    //    //h = Input.GetAxis("Mouse X");
    //    //v = Input.GetAxis("Mouse Y");
    //    //rb.AddForce(new Vector3((-h) * Sensitivity, 0, (-v) * Sensitivity));
    //    //rb.AddForce(new Vector3((Input.mousePosition.x - pos.x) * Sensitivity, 0, (-Input.mousePosition.y + pos.y) * Sensitivity));

    //}
}
