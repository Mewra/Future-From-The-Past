using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour {

	public GameObject player;
	public GameObject future;
	public GameObject past;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.y>0){
			future.SetActive (true);
			past.SetActive (false);
		}else{
			past.SetActive (true);
			future.SetActive (false);
		}
	}
}
