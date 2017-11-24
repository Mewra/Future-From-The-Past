using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObBackground : MonoBehaviour {

	private bool PlayerTouch;
	public GameObject _target;
	// private gameObject _background;

	
	// Use this for initialization
	void Start () {
		PlayerTouch=false;
		// Debug.Log ("I AM " + gameObject.name);
		// _target=GetComponent<>() as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log ("I AM " + gameObject.name);
		if (Input.GetKeyDown (KeyCode.M) && PlayerTouch) {
			Debug.Log("wtf???");
			gameObject.SetActive(false);
			_target.SetActive(true);
			
		}
	}

	void OnTriggerExit2D(Collider2D coll){
		PlayerTouch = false;
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			Debug.Log("COLLIDE");
			PlayerTouch = true;
		}
	}
}
