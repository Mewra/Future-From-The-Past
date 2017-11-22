using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	public int _maxPieces;
	private static int _piecesCollected = 0;
	public GameObject _piece;
	//private GameObject [] pieces = new GameObject [_maxPieces];
	public GameObject _buildable;
	private Transform _transformBuildable;
	private string _tag;

	// Use this for initialization
	void Start () {

		_transformBuildable = _buildable.GetComponent<Transform> ();
		_tag = _buildable.tag;
		_buildable.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			_piecesCollected++;
			if (_piecesCollected == _maxPieces) {
				_buildable.SetActive (true);
			}
			_piece.SetActive (false);
		}
	}


}
