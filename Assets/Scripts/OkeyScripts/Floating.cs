using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {

	private TweenTransforms _ImTransf;
	private Transform _transform;

	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>();
		_ImTransf = GetComponent<TweenTransforms> ();
		_ImTransf.startingVector = _transform.position;

		_ImTransf.endVector = new Vector3 (transform.position.x -0.05f + Random.value * (0.05f), transform.position.y -0.05f + Random.value * (0.05f), transform.position.z);
		_ImTransf.myTweenType = TweenBase.playStyles.PingPong;
		_ImTransf.duration = 1.5f;
		_ImTransf.Begin ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
