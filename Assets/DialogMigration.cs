using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogMigration : MonoBehaviour {

	public GameObject player;
	public Text text;
	public Text text1;
	public Text text2;
	private float xToAppear=-1.0f;
	public Image img;
	public Image img1;
	public Image img2;
	private bool executeOnce=true;



	void Start () {
		text1.enabled = false;
		text2.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		
		if (executeOnce&&(player.transform.position.x>xToAppear)){
			text.enabled = false;
			img1.enabled = false;
			img2.enabled = false;
			text1.enabled = true;
			executeOnce=false;
		}

		if (!executeOnce && (player.transform.position.y > 0 && player.transform.position.x > 5.0)) {
			text1.enabled = false;
			img1.enabled = false;
			img2.enabled = false;
			text2.enabled = true;
		}





	}
}