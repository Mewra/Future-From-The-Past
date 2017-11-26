using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstaclesUp: MonoBehaviour {

	private TweenTransforms _ImTransf;
	private bool isMoving=true;
	private Transform _transform;
	private IEnumerator coroutine;
	private IEnumerator coroutine1;
	private bool usable = true;

	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

		//StopTime
		if(Input.GetKeyDown(KeyCode.N)){
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
		isMoving= false;
		_transform.rotation = new Quaternion (0,0, _transform.eulerAngles.z, 0);
		yield return new WaitForSeconds (2.0f);
		_transform.Rotate (new Vector3 (0, 0, -300) * Time.deltaTime);
		isMoving = true;
	}

	private IEnumerator Cooldown(){
		yield return new WaitForSeconds (5.0f);
		usable = true;
	}
}
