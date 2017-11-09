using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerImageTurn : MonoBehaviour {

	private Transform _transform;
	//private bool Future = true;
	public GameObject _Residue;
	public GameObject _Player;
	public GameObject _ImagineTurn;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.L)) {

			_ImagineTurn.SetActive (true);
			_Player.SetActive (false);
			_Residue.SetActive (false);


			GetComponent<TweenTransforms> ().startingVector = _Player.transform.position;
			GetComponent<TweenTransforms> ().endVector = _Residue.transform.position;

			GetComponent<TweenSequence> ().BeginSequence ();

		}
		
	}
}
