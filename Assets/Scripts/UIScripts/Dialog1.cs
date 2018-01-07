using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog1 : MonoBehaviour {

	public GameObject player;
	public GameObject text;
	public float xToAppear=0.0f;

	private bool executeOnce=true;
	private float nextTime=0.0f;


	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (executeOnce&&(player.transform.position.x>xToAppear)){
			text.SetActive(true);
			nextTime=Time.time+5.0f;
			executeOnce=false;
		}
		if (Time.time>nextTime){
			text.SetActive(false);
		}
	}
}
