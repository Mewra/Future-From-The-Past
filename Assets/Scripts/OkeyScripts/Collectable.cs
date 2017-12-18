using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {

	public int _maxPieces;
	public static int _piecesCollected = 0;
	public GameObject _piece;
	//private GameObject [] pieces = new GameObject [_maxPieces];
	public GameObject _buildable;
	private Transform _transformBuildable;
	private string _tag;

	public Text text;
	public Canvas canv;
	public Image box;
	public Image pieces;

	// Use this for initialization
	void Start () {

		_transformBuildable = _buildable.GetComponent<Transform> ();
		_tag = _buildable.tag;
		//_buildable.SetActive (false);



		box.enabled = false;


		text.text = _piecesCollected + "/" + _maxPieces;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			_piecesCollected++;
			text.text = _piecesCollected + "/" + _maxPieces;
			if (_piecesCollected == _maxPieces) {
				_buildable.SetActive (true);
				box.enabled = true;
				text.enabled = false;
				pieces.enabled = false;
				_piecesCollected = 0;
			}
			_piece.SetActive (false);
		}
	}


}
