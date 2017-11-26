using UnityEngine;
using System.Collections;

public class ObFollowing : MonoBehaviour {

	public GameObject _target;
	private Transform _transform;
	private Transform _targetTransf;

	// Use this for initialization
	void Start () {
		
		_transform = GetComponent<Transform>() as Transform;
		_targetTransf = _target.GetComponent<Transform> () as Transform;

	}

	// Update is called once per frame
	void Update () {
			_transform.position = new Vector3 (_targetTransf.position.x, _transform.position.y, _transform.position.z);
	}




}

