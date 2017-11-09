using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTurn : MonoBehaviour {

	private Transform _transform;
	public static bool Future = true;
	public GameObject _Residue;
	public GameObject _Player;
	public GameObject _ImagineTurn;
	private TweenTransforms _ImTransf;
	private TweenTransforms _ImScale;
	private TweenTransforms _ImRotate;
	private Rigidbody2D _playerRb;
	private bool tmp;


	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>() as Transform;
		_playerRb = _Player.GetComponent<Rigidbody2D> () as Rigidbody2D;
		_ImTransf = _ImagineTurn.GetComponent<TweenSequence> ().tweenSequence[1] as TweenTransforms;
		_ImScale = _ImagineTurn.GetComponent<TweenSequence> ().tweenSequence[3] as TweenTransforms;
		_ImRotate = _ImagineTurn.GetComponent<TweenSequence> ().tweenSequence[2] as TweenTransforms;

	}

	public static bool getFuture(){
		return Future;
	}

	// Update is called once per frame

	void Update () {

		if (Input.GetKeyDown (KeyCode.E)) {
				/*if (Future == true) {
				GetComponent<TweenTransforms> ().startingVector = new Vector3 (0, 0, 0);
				GetComponent<TweenTransforms> ().endVector = new Vector3 (0, -180, -180);
			}else{
				GetComponent<TweenTransforms> ().startingVector = new Vector3(0, -180, -180);
				GetComponent<TweenTransforms> ().endVector = new Vector3(0, -360, -360);
			}

			GetComponent<TweenTransforms> ().Begin ();

			_ImagineTurn.SetActive (true);
			_Player.SetActive (false);
			_Residue.SetActive (false);


			_ImTransf.startingVector = _Player.transform.position;
			_ImTransf.endVector = new Vector3(0,0,0);
			_ImScale.startingVector = _Player.transform.lossyScale;
			_ImScale.endVector = new Vector3 (2.0f, 2.0f, _Player.transform.lossyScale.z);
			_ImRotate.startingVector = new Vector3 (0,0,0);
			_ImRotate.endVector = new Vector3 (_Player.transform.rotation.x, _Player.transform.rotation.y, -360);

			_ImagineTurn.GetComponent<TweenSequence> ().BeginSequence ();*/



				if (Future == true)
					Future = false;
				else
					Future = true;

				if (Future == false)
					_playerRb.gravityScale = -1;//1
				else
					_playerRb.gravityScale = 0;

				_Player.transform.position = _Residue.transform.position;
				_Player.transform.Rotate (new Vector3 (0, 180, 180));

				_Residue.transform.position = _Player.transform.position;
				_Residue.transform.Rotate (new Vector3 (0, 180, 180));



		}

		if (_Player.transform.position == _ImagineTurn.transform.position) {
			_ImagineTurn.GetComponent<TweenSequence> ().StopSequence ();
			_ImagineTurn.SetActive (false);
			_Player.SetActive (true);
			_Residue.SetActive (true);

		}

	}
}
