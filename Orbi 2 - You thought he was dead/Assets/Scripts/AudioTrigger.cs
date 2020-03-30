using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioTrigger : MonoBehaviour {

    public AudioSource audioSource;
    public GameObject Trigger;
    private bool enter;



    void Start ()
    {
        enter = true;
        audioSource = gameObject.GetComponent<AudioSource>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (enter == true)
            {
                audioSource.Play();
                enter = false;
            }
            else
            {
                print("false");
            }

        }
    }    
}
