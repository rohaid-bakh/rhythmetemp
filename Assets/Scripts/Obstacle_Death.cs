﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle_Death : MonoBehaviour
{
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            audioSource.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
