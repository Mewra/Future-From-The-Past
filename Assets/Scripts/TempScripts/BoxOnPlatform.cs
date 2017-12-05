using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOnPlatform : MonoBehaviour {


	private Transform _transform;
	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform> ();

		
	}

	// Update is called once per frame
	void Update () {


		
	}

    void OnCollisionStay2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "MovingPlatform")
		{
			_transform.parent = coll.transform;
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "MovingPlatform")
		{
			transform.parent = null;
		}
	}
}
