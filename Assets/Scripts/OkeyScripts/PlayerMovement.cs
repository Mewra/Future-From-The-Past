using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {
	[Header("Player Speed")]
	[Range(0.0f,5.0f)]
	public float m_speed = 2.5f;

	[Header("Player Jump")]
	[Range(0.0f,7.0f)]
	public float m_jumpHeight = 2.5f;

	private float m_horizontal;
	private float m_vertical;

	private bool InTheFuture;
	// This variable remain true when the player is in future

	private Transform _transform;
	private Rigidbody2D _rigidbody;

<<<<<<< HEAD
	private float nextTime=0.0f;
=======
	private SpriteRenderer _playerSpriteRenderer;
>>>>>>> master

	// Use this for initialization
	void Start () {
		// Debug.Log ("I AM " + gameObject.name);
		InTheFuture=true;
		// _animator = GetComponent<Animator>() as Animator;
		_transform = GetComponent<Transform>() as Transform;
		_rigidbody = GetComponent<Rigidbody2D>() as Rigidbody2D;

		// nextTime=0.0f;
		// state = State.Idle;

		_playerSpriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {	
		if(InTheFuture==true){

			m_horizontal = Math.Sign(Input.GetAxis ("Horizontal"));
			m_vertical = Math.Sign(Input.GetAxis ("Vertical"));

			_transform.position = _transform.position +
				_transform.right * m_horizontal * m_speed * Time.deltaTime +
				_transform.up * m_vertical * m_speed * Time.deltaTime;
		}else{

			m_horizontal = Math.Sign(Input.GetAxis ("Horizontal"));
			m_vertical = Math.Sign(Input.GetAxis ("Vertical"));		

			_transform.position = _transform.position +
				_transform.right * m_horizontal * m_speed * Time.deltaTime +
				_transform.up * m_vertical * m_jumpHeight * Time.deltaTime;
		}
		
		if (Input.GetKeyDown(KeyCode.J))
		{
			// Debug.Log(nextTime+"!@#");
			nextTime=Time.time+1.0f;
			// Debug.Log("TIME TRAVEL! next time is "+nextTime+" now Time is: "+Time.time);

			InTheFuture=!InTheFuture;

			if(InTheFuture==true){
				_rigidbody.gravityScale=0;
				SoundManager.Instance.PastTravelToFuture();
			}
			else {
				_rigidbody.gravityScale=-1;
				SoundManager.Instance.FutureTravelToPast();
			}
				
			SoundManager.Instance.SwitchBGM1(InTheFuture);
			_rigidbody.Sleep();

			Vector3 playerPositionNow = _transform.position;
			_transform.position = new Vector3(playerPositionNow.x, -playerPositionNow.y, playerPositionNow.z);
			//_transform.Rotate (0, 180, 180);
			bool aa = _playerSpriteRenderer.flipY;

			
			// Press J to Switch to another gravity System
		}

		if ((Time.time>nextTime)&&(nextTime!=0.0f)){
			SoundManager.Instance.SwitchBGM2(InTheFuture);
			nextTime=0.0f;
		}
		
	}
		
}
