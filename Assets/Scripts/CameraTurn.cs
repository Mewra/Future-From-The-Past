using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurn : MonoBehaviour {

	private Transform _transform;
	public GameObject _player;
	public Transform _player_transform;

	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>() as Transform;

	}
	
	// Update is called once per frame

	void Update () {

		if (Input.GetKeyDown (KeyCode.L)) {

			_transform.position= new Vector3(0,0,-(_transform.position.z));

			_transform.Rotate(new Vector3 (0, 180, 180));

			//_player_transform.Rotate (new Vector3 (0, 180, 180));
			//_player_transform.position = new Vector3 (_player_transform.position.x, -(_player_transform.position.y), _player_transform.position.z);

			//_player.GetComponent<Rigidbody>().useGravity = false;

		}
		
	}
}
