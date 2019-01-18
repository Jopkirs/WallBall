using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public LevelManager levelManager;

    // Use this for initialization
    void Start() {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    /*
     * Uncomment if you want multiple checkpoints
     * 
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.name == "Ball") {
            levelManager.currentCheckPoint = gameObject;
            Debug.Log("Activated Chekcpoint " + transform.position);
        }
    }
    */
}
