using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {


	public GameObject _UI;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	// Update is called once per frame
	void OnTriggerStay2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			// 	Debug.Log("Enter the exit");
			// 	_UI.SetActive(true);
			// }
			// Debug.Log("Enter the exit");
			_UI.SetActive (true);
		}
	}
}
