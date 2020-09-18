using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;

public class Obstacle_Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
        ApplicationActivator.LoadLevel(ApplicationActivator.loadedLevel);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
