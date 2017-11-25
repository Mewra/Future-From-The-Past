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
	private bool PlayerTouch=false;


	private Vector3 _initialScale;
	private Vector3 _initialPosition;
	private Quaternion _initialRotation;
	private bool _migrated;

	private bool obRotateBlocked;

	// Use this for initialization
	void Start ()
	{	
		_transform = GetComponent<Transform>();
		_transformOther = _other.GetComponent<Transform> ();
		_tag = _obstacle.tag;

		if (_tag.Equals ("ObRotating")) {
			// _ImTransf = GetComponent<TweenTransforms> ();
			// _ImTransf.startingVector = new Vector3 (_transform.rotation.x, _transform.rotation.y, _transform.rotation.z);
			// _ImTransf.endVector = new Vector3 (0, 0, -360 - _ImTransf.startingVector.z);
			// _ImTransf.Begin ();
			obRotateBlocked=true;
		}

		if (_tag.Equals ("ObMigratable")) {
			_migrated = false;
			_ImTransf = GetComponent<TweenTransforms> ();
		}

	}

	void Awake(){
		_transform = GetComponent<Transform> ();
		_initialPosition = _transform.position;
		_initialRotation = _transform.rotation;
		_initialScale = _transform.localScale;

	}
	
	// Update is called once per frame
	void Update ()
	{	
		if (_tag.Equals ("ObMigratable")) {
			if (Input.GetKeyDown (KeyCode.M) && PlayerTouch) {
				if (!_migrated) {
					_transform.position = new Vector3 (_transformOther.position.x, -_transformOther.position.y, _transformOther.position.z);
					_transform.Rotate(new Vector3 (0,0, -_transformOther.eulerAngles.z));
					_migrated = true;
				} else {
					_transform.position = _initialPosition;
					_transform.rotation = _initialRotation;
					_migrated = false;
				} 
				
			}
		}

		if (_tag.Equals("ObRotating")){
			if (!obRotateBlocked){
				transform.Rotate (new Vector3 (0, 0, -50) * Time.deltaTime);
			}
		}
	}

	void OnCollisionExit2D(Collision2D coll){
		//When the obstacle rotating is not touching anything it will rotate
		if(_tag.Equals ("ObRotating")){
			// if (_ImTransf.isPlaying) {
			// 	_ImTransf.Resume ();
			// }
			obRotateBlocked=false;
		}
		PlayerTouch = false;
	}

	void OnCollisionEnter2D(Collision2D coll){
		//Block the movement of the obstacle rotating if hits something
		if (_tag.Equals ("ObRotating") && coll.gameObject.tag=="Box") {
			// if (_ImTransf.isPlaying) {
			// 	_ImTransf.Pause ();
			// }
			obRotateBlocked=true;
		}

		if (coll.gameObject.tag == "Player") {
			PlayerTouch = true;
		}

		if (_tag.Equals ("Portal") && coll.gameObject.tag == "Box") {
			_transformOther.position = new Vector3 (_transformOther.position.x, -_transformOther.position.y, _transformOther.position.z);
			_other.GetComponent<Rigidbody2D>().gravityScale = 0;

		}

		if (_tag.Equals ("Radiation") && coll.gameObject.tag == "Box") {
			_transform.localScale = new Vector3 (_transform.localScale.x, _transform.localScale.y / 3);
			_transform.position = _transform.position + _transform.up * -1;

		}


	}


}

