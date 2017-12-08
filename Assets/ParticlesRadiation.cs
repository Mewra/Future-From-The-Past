using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesRadiation : MonoBehaviour {


	private ParticleSystem _particle;
	// Use this for initialization
	void Start () {
		
		_particle = GetComponentInChildren<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.tag == "Box") {
			GetComponent<BoxCollider2D> ().enabled=false;
			_particle.Stop ();

		}
	}

	void OnTriggerExit2D(Collider2D coll){

		if (coll.gameObject.tag == "Box") {
			GetComponent<BoxCollider2D> ().enabled=true;
			_particle.Play ();

		}
	}
}
