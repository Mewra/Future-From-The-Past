using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gotonextlevel : MonoBehaviour {
	private string nextLevel;
	private int levelNum;

	void Start () {
	}

    void Awake(){
        Button button = GetComponent<Button>() as Button;
        button.onClick.AddListener(btClick);
		nextLevel=button.name;
    }

    void Update () {
		if ((Input.GetKeyDown (KeyCode.J))||
			(Input.GetKeyDown (KeyCode.K))||
			(Input.GetKeyDown (KeyCode.L))||
			(Input.GetKeyDown (KeyCode.Return))){
			btClick();
		}
	}

    void btClick()
    {
        print("Button Click");
		print(nextLevel);
		switch (nextLevel)
		{
			case "1":
				levelNum=1;
				break;
			case "2":
				levelNum=2;
				break;
			case "3":
				levelNum=3;
				break;
			case "4":
				levelNum=4;
				break;
			case "5":
				levelNum=5;
				break;
			case "6":
				levelNum=6;
				break;
			case "7":
				levelNum=7;
				break;
			case "8":
				levelNum=8;
				break;
			case "9":
				levelNum=9;
				break;
			case "10":
				levelNum=10;
				break;
			case "11":
				levelNum=11;
				break;
			case "12":
				levelNum=12;
				break;

			default:
				Debug.Log("WRONG NUMBER");
				break;
		}
		Time.timeScale=1;
        SceneManager.LoadScene(levelNum);
    }
}
