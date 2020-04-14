using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject nextLevel;
    public GameObject thisLevel;
    public float newX;
    public float newY;
    public float newZ;
    public AudioClip levelComplete;
    AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        //make sure player hits the exit
        //if (other.gameObject.CompareTag("Player"))
        
            //Debug.Log("Steve");
            //turns off current level
            thisLevel.SetActive(false);
            //turns on next level
            nextLevel.SetActive(true);
            //resets player location
            other.transform.position = new Vector3(newX, newY, newZ);
            audioSource.clip = levelComplete;
            audioSource.Play();
        
    }
}
