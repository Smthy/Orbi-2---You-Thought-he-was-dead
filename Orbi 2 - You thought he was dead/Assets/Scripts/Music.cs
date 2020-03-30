using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Music : MonoBehaviour
{
    private Scene scene;
    public AudioSource music;
    void Update()
    {
        if(scene.name == "EndGame")
        {
            music.enabled = false;
        }
        else
        {
            DontDestroyOnLoad(this);
            music.enabled = true;
        }
    }
}
