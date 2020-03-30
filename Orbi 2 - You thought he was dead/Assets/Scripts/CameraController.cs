using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private float movePercentage, mSpeed;
    private bool CameraMove;


    void Start()
    {
        movePercentage = 0;
        mSpeed = 1.25f;
        player = GameObject.FindWithTag("Player");
        MoveSpeed();
        CameraMove = true;
    }

	void Update ()
    {       
        if (CameraMove == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 10), movePercentage);
        }    
	}

    void MoveSpeed()
    {
        movePercentage += mSpeed * Time.deltaTime;
        if(movePercentage > 1f)
        {
            movePercentage = 1f;
        }
    }
}

