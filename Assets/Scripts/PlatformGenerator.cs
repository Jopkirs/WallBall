using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    public GameObject prefab;
    public Transform generationPoint;
    public float distanceBetweenObjects;

    private float screenWidth;
    private float randomPositionX;

    void Start() {
        screenWidth = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x + 2;
    }

    // Update is called once per frame
    void Update () {

        //check if object got past the generationPoint
        //if so generate the object at a random position along the x axis
		if(transform.position.y < generationPoint.position.y) {
            
            randomPositionX = Random.Range(-screenWidth, screenWidth);
            
            Vector3 position = new Vector3(
                randomPositionX,
                transform.position.y + distanceBetweenObjects,
                transform.position.z
                );
            transform.position = position;
            Instantiate(prefab, position, Quaternion.identity);
        }
	}
}
