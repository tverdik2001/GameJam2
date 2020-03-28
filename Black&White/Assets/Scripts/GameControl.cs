using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance1;
    public GameObject gameOverText;
    public bool gameOver=false;
    public float scrollSpeed= -1.5f;
    private int score=0;
    public Text scoreText;

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
        if (gameOver&&Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        
    }
    public void pointScored(){
        if(gameOver){
             Debug.Log("steve");
            return;
           
        }
        score++;
        scoreText.text="Score:" + score.ToString();
        

    }
    public void ghostDied(){
        gameOverText.SetActive(true);
        gameOver=true;

    }
}
