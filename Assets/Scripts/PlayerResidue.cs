using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerResidue : MonoBehaviour {

	public GameObject _player;
	private Transform _transform;
	private Transform _playertransf;
	private static bool cantTurn=false;


	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>() as Transform;
		_playertransf = _player.GetComponent<Transform> () as Transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		_transform.position = new Vector3 (_playertransf.position.x,-_playertransf.position.y,_playertransf.position.z);
		//cantTurn = true;
		
	}

	public static bool GetCantTurn(){
		return cantTurn;
	}

	void OnCollisionEnter(Collision other)
	{
			cantTurn = true;

	}
}
