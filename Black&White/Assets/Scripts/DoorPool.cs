using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPool : MonoBehaviour
{
    public int columnPoolSize=5;
    private GameObject[] columns;
    public GameObject columnPrefab;
    private Vector2 objectPoolPosition= new Vector2 (-15f,-25f);
    private float timeSinceSpawn;
    public float spawnRate = 3f;
    public float columnMin=-1f;
    public float columnMax=3.5f;
    private float spawnXPos=10f;
    private int curColumn=0;
    // Start is called before the first frame update
    void Start()
    {
        columns=new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i]=(GameObject) Instantiate(columnPrefab,objectPoolPosition, Quaternion.identity);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn+=Time.deltaTime;
        if(!GameControl.instance1.gameOver&&timeSinceSpawn>=spawnRate){
            timeSinceSpawn=0;
            float spawnPosY=Random.Range(columnMin,columnMax);
            columns[curColumn].transform.position=new Vector2(spawnXPos,spawnPosY);
            curColumn++;
            if(curColumn>=columnPoolSize){
                curColumn=0;
            }
        }
    }
}
