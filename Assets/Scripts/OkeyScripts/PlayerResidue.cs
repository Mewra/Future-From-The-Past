using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerResidue : MonoBehaviour {

	public GameObject _player;
	private Transform _transform;
	private Transform _playertransf;
	private static bool canTurn=true;

	//private Collider2D [] obj;
	//private SpriteRenderer _playerSpriteRenderer;


	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>() as Transform;
		_playertransf = _player.GetComponent<Transform> () as Transform;
		//_playerSpriteRenderer = GetComponent<SpriteRenderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		_transform.position = new Vector3 (_playertransf.position.x,-_playertransf.position.y,_playertransf.position.z);


		/*if (Input.GetKeyDown (KeyCode.J)) {
			obj = Physics2D.OverlapCircleAll (_transform.position, 0.4f);
			//Debug.Log ("Length: " + obj.Length);
			if (obj.Length != 1) {
				canTurn = false;
			} else {
				canTurn = true;
			}

			Debug.Log ("Can Turn?" + canTurn);
		}*/
	}

	public static bool GetCanTurn(){
		return canTurn;
	}


}
