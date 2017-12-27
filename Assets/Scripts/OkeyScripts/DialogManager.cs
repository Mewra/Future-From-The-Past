using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour {

	public GameObject player;
	public GameObject text;
	public GameObject text2;
	// Use this for initialization
	private bool OnlyShowOnce=true;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OnlyShowOnce && (player.transform.position.y <0)){
			text.SetActive(false);
			text2.SetActive(true);
			OnlyShowOnce=false;
		}
		if ((player.transform.position.y >0)||(player.transform.position.x>10)){
			text2.SetActive(false);
		}
	}
}
