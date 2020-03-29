using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance1;
    public bool gameOver=false;
    public float scrollSpeed= -1.5f;
 

    // Start is called before the first frame update
    void Awake()
    {
        if (instance1==null){
            instance1=this;
        }else if(instance1!=this){
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
  
}
