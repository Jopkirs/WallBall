using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    public GameObject platformGameObject;
    public Transform generationPoint;
    public float distanceBetweenObjects;
    
	// Update is called once per frame
	void Update () {
		if(transform.position.y < generationPoint.position.y) {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + distanceBetweenObjects,
                transform.position.z
                );
            Instantiate(platformGameObject, transform.position, transform.rotation);
        }
	}
}
