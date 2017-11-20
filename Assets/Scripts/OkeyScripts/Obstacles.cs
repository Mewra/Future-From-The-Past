using UnityEngine;
using System.Collections;

public class Obstacles : MonoBehaviour
{
	private Transform _transform;
	private TweenTransforms _ImTransf;
	public GameObject _obstacle;
	private string _tag;
	public GameObject _other;
	private Transform  _transformOther;

	// Use this for initialization
	void Start ()
	{	_transformOther = _other.GetComponent<Transform> ();
		_transform = GetComponent<Transform>();
		_ImTransf = GetComponent<TweenTransforms> ();
		_ImTransf.startingVector = new Vector3 (_transform.rotation.x, _transform.rotation.y, _transform.rotation.z);
		_tag = _obstacle.tag;

		if (_tag.Equals ("ObRotating")) {
			_ImTransf.endVector = new Vector3 (0, 0, -360 - _ImTransf.startingVector.z);
			_ImTransf.Begin ();
		}

	}
	
	// Update is called once per frame
	void Update ()
	{	
		
	}

	void OnCollisionExit2D(Collision2D coll){
		if (_ImTransf.isPlaying) {
			_ImTransf.Resume ();
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (_ImTransf.isPlaying) {
			_ImTransf.Pause ();
		}
	}


}

