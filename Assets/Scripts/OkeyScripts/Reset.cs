using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	private Transform _transform;

	private Vector3 _initialPosition;
	private Quaternion _initialRotation;
	private Vector3 _initialScale;


	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform> ();
		
	}

	void Awake(){
		_transform = GetComponent<Transform> ();
		_initialPosition = _transform.position;
		_initialRotation = _transform.rotation;
		_initialScale = _transform.localScale;

	}
	
	// Update is called once per frame
	void Update () {

		//Reset this object to his initial position
		if (Input.GetKeyDown (KeyCode.R)) {
			_transform.position = _initialPosition;
			_transform.rotation = _initialRotation;
		}
		
	}


}
