using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle_Death : MonoBehaviour
{
    AudioSource audioSource;
    bool m_play = true;
    bool m_toggle = true;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("Test 0");
  
        audioSource = GetComponent<AudioSource>();
              audioSource.Play();
        
    }

   //add boolean to toggle sound ?? 


    // Update is called once per frame
    void Update(){
    Debug.Log(audioSource.time);
      Debug.Log("Test 1");
       if (m_toggle == true) {
         audioSource.Stop();
         m_toggle = false;
         m_play = true;
       }
       if (m_play == true && m_toggle == false) {
         audioSource.Play();
         m_play = false;
       }

    }

      void OnCollisionEnter2D(Collision2D col) {
        //Resets players to original position
        if(col.gameObject.tag == "Death"){
        Debug.Log("Test 1");
        transform.position = new Vector3(-13, 5, 0);
        m_toggle = true;
        }
    }
        
}
