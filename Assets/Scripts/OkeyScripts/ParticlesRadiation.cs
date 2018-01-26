using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesRadiation : MonoBehaviour {


	private ParticleSystem _particle;
	private Transform transf;
	// Use this for initialization
	void Start () {
		transf = GetComponent<Transform>() as Transform;
		_particle = GetComponentInChildren<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.tag == "Box") {
			GetComponent<BoxCollider2D> ().enabled=false;
			_particle.Stop ();
			//coll.gameObject.GetComponent<Transform> ().position = new Vector3 (transf.position.x, transf.position.y + 0.5f, transf.position.z);
			//coll.gameObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;

		}
	}

	void OnTriggerExit2D(Collider2D coll){

		if (coll.gameObject.tag == "Box") {
			GetComponent<BoxCollider2D> ().enabled=true;
			_particle.Play ();
			coll.gameObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;

		}
	}
}
