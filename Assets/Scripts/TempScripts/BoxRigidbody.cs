using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRigidbody : MonoBehaviour {

	private Rigidbody2D _RB;
	// Use this for initialization
	void Start () {
		_RB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onCollisionEnter(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			_RB.WakeUp ();
		}
	}

	void onCollisionExit(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			_RB.Sleep ();
		}
	}
}
