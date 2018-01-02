using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimeHorizontal : MonoBehaviour {

	public GameObject pipeline;
	private float nextTime=0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K)){
			// GameObject[] objs;
			// objs= GameObject.FindGameObjectsWithTag("HorizontalMoveObj");
			// foreach(GameObject obj in objs){
			// 	// obj.ObjectMoveHorizontal.Instance.setSpeedZero();
			// }
			pipeline.SetActive(false);
			nextTime=Time.time+5.0f;
		}

		if (Time.time>nextTime){
			pipeline.SetActive(true);
		}
	}
}
