using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateHorizontalObj : MonoBehaviour {

	public Transform prefab;

	//public float timeDif=0.5f;
	private float nextTime;
	private IEnumerator coroutine;
	public static bool stop = false;
	public static bool done;

	// Use this for initialization
	void Start () {
		done = true;
		//nextTime=0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (!stop) {
			if (done) {
				/*if (Time.time > nextTime) {
				Instantiate (prefab);
				nextTime = nextTime + timeDif;
			}*/
				coroutine = istant ();
				StartCoroutine (coroutine);
			}
		}
		
		
	}

	private IEnumerator istant(){
		Instantiate (prefab);
		done = false;
		yield return new WaitForSeconds (0.7f);
		done = true;
	}

	public static void setStop (bool stopit){
		stop = stopit;
	}

}
