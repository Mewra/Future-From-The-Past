using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	private Vector3 offset;

	void Start () {
		// offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPosition =player.transform.position;
		// transform.position = player.transform.position + offset;
		// if (playerPosition.x<-2.3)
		// 	return;
		transform.position = new Vector3(playerPosition.x,0,-10);
	}
}
