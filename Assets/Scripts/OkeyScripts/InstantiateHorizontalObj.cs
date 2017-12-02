using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateHorizontalObj : MonoBehaviour {

	public Transform prefab;

	public float timeDif=0.5f;
	private float nextTime;

	// Use this for initialization
	void Start () {
		nextTime=0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time>nextTime){
			Instantiate(prefab);
			nextTime=nextTime+timeDif;
		}
	}
}
