using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour {

	public GameObject player;
	public GameObject text;
	public GameObject text2;
	// Use this for initialization

	public float playerPosition=10.0f;
	private bool OnlyShowOnce=true;
	private float nextTime=0.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OnlyShowOnce && (player.transform.position.y <0)){
			text.SetActive(false);
			text2.SetActive(true);
			OnlyShowOnce=false;
			nextTime=Time.time+5.0f;
		}
		// if ((player.transform.position.y >0)||(player.transform.position.x>playerPosition)){
		// 	text2.SetActive(false);
		// }
		if (Time.time>nextTime){
			text2.SetActive(false);
		}
	}
}
