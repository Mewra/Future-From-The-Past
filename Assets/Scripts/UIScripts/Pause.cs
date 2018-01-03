using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	public GameObject _UIIngame;
	// Use this for initialization
	void Start () {
	}
	
	void Awake()
    {
        Button button = GetComponent<Button>() as Button;
        button.onClick.AddListener(btClick);
    }

	// Update is called once per frame
	void Update () {
	}

	void btClick()
    {
        print("Button Click");
        _UIIngame.SetActive (true);
		Time.timeScale=0;
    }
}
