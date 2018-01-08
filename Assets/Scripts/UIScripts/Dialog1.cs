using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog1 : MonoBehaviour {

	public GameObject player;
	public Text text;
	public float xToAppear=0.0f;
	public Image img;
	public Image img1;
	private bool executeOnce=true;
	private float nextTime=0.0f;


	void Start () {
		text.enabled = false;
		img.enabled = false;
		img1.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (executeOnce&&(player.transform.position.x>xToAppear)){
			text.enabled = true;
			img.enabled = true;
			img1.enabled = true;
			//nextTime=Time.time+10.0f;
			executeOnce=false;
		}

		/*if (Time.time>nextTime){
			text.SetActive(false);
		}*/
	}
}
