using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

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
			Time.timeScale=1;
			Scene scene = SceneManager.GetActiveScene(); 
			SceneManager.LoadScene(scene.name);
		}
}
