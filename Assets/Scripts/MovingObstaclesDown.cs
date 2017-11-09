using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstaclesDown: MonoBehaviour {

	private TweenTransforms _ImTransf;
	private bool isMoving=true;
	private Transform _transform;
	private IEnumerator coroutine;
	private IEnumerator coroutine1;
	private bool usable = true;

	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>();
		_ImTransf = GetComponent<TweenTransforms> ();
		_ImTransf.startingVector = _transform.position;
		_ImTransf.endVector = new Vector3 (transform.position.x, transform.position.y - 5.0f, transform.position.z);
		_ImTransf.Begin ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Q)){
			if (usable){
				coroutine1 = Cooldown ();
				StartCoroutine (coroutine1);
				coroutine = StopTime ();
				StartCoroutine (coroutine);


				/*if (isMoving == true) {
				_ImTransf.Pause ();
				isMoving = false;
			} else {
				_ImTransf.Resume ();
				isMoving = true;
			}*/
			}
			usable = false;
		}

	}

	private IEnumerator StopTime(){
		_ImTransf.Pause ();
		isMoving= false;
		yield return new WaitForSeconds (2.0f);
		_ImTransf.Resume ();
		isMoving = true;
	}

	private IEnumerator Cooldown(){
		yield return new WaitForSeconds (5.0f);
		usable = true;
	}
}
