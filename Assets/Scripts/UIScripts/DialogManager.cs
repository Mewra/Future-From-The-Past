using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

	//Manager for level 1, 2

	public GameObject player;
	public Text text;
	public Text text2;
	public Text text3;
	public Image img;
	// Use this for initialization

	public float playerPosition=10.0f;
	private bool OnlyShowOnce=true;
	private float nextTime=0.0f;

	void Start () {
		text2.enabled = false;
		img.enabled = false;
		text3.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (OnlyShowOnce && (player.transform.position.y < 0)) {
			//text.SetActive (false);
			//text2.SetActive (true);
			text.enabled = false;
			text2.enabled = true;
			img.enabled = true;
			OnlyShowOnce = false;
			nextTime = Time.time + 10.0f;
		}

		if(!OnlyShowOnce && (player.transform.position.y > 0 && player.transform.position.x > -2)){
			text2.enabled = false;
			text3.enabled = true;
			img.enabled = false;
		}

		// if ((player.transform.position.y >0)||(player.transform.position.x>playerPosition)){
		// 	text2.SetActive(false);
		// }

		if (Time.time>nextTime){
			//text2.SetActive(false);
			//text2.text = "<i>Press <b> J </b> to Time Travel</i>";
		}
	}
}
