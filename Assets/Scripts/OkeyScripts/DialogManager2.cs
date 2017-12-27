using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager2 : MonoBehaviour {

	public GameObject player;
	public GameObject text;

	private bool executeOnce=true;

	public float x_start = 0;
	public float x_end = 3.0f;

	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (executeOnce&&(player.transform.position.x>x_start)){
			text.SetActive(true);
			executeOnce=false;
		}
		if (player.transform.position.x>x_end){
			text.SetActive(false);
		}
	}
}
