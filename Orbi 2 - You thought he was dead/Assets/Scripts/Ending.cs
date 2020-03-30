using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public ParticleSystem expolision;
    public GameObject player, earth, joeface;

    public void Start()
    {
        joeface.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(earth);
            expolision.Play();

            Destroy(player, 1f);
            Destroy(expolision, 4f);
            joeface.SetActive(true);
            Destroy(this);

        }
    }
}
