using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartNewGame : MonoBehaviour {

	void Start () {
	}

    void Awake()
    {
        Button button = GetComponent<Button>() as Button;
        button.onClick.AddListener(btClick);
    }
    

    void Update () {
	}

    void btClick()
    {
        print("Button Click");
        SceneManager.LoadScene(1);
    }
}
