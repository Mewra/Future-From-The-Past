using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonToMenu : MonoBehaviour {

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
        SceneManager.LoadScene(0);
    }
}
