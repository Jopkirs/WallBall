using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckPoint;

    private PlayerControll player;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType <PlayerControll > ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer() {
        player.transform.position = currentCheckPoint.transform.position;
        player.setVelocityToZero();
    }
}
