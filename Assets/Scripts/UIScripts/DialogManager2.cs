using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager2 : MonoBehaviour {

	public GameObject player;
	public Text text;
	public Image img;
	public Image img1;
	public Image img2;

	private bool executeOnce=true;
	private float nextTime=0.0f;
	// public float x_start = 0;
	// public float x_end = 3.0f;

	// Use this for initialization

	void Start () {
		text.enabled=false;
		img.enabled = false;
		img1.enabled = false;
		img2.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (executeOnce&&(player.transform.position.y<0)){
			text.enabled=true;
			img.enabled = true;
			img1.enabled = true;
			//nextTime=Time.time+10.0f;
			executeOnce=false;
		}

		if (!executeOnce && player.transform.position.y > 0 && player.transform.position.x > -1.7f) {
			img1.enabled = false;
			text.text = "''A  seesaw!  \n  Let's  make  that  box  fly!''";
			img2.enabled = true;
		}

		/*if (Time.time>nextTime){
			text.SetActive(false);
		}*/
		// if (player.transform.position.x>x_end){
		// 	text.SetActive(false);
		// }
	}
}
