using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveHorizontal : MonoBehaviour {

	private Transform _objTransform;
	public float moveSpeed=5.0f;
	// Use this for initialization
	void Start () {
		_objTransform=GetComponent<Transform>() as Transform; 	
	}
	
	// Update is called once per frame
	void Update () {
		_objTransform.position = _objTransform.position -
				_objTransform.right * moveSpeed * Time.deltaTime;
	}

	// void DestroyObjectDelayed(){
    //     // Kills the game object in 5 seconds after loading the object
    //     Destroy(gameObject, 5);
	// 	Debug.Log("This obj has been destroyed");
    // }
}
