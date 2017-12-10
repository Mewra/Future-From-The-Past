using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {
	[Header("Player Speed")]
	[Range(0.0f,5.0f)]
	public float m_speed = 2.5f;

	[Header("Player Jump")]
	[Range(0.0f,50.0f)] //prima da 0 a 7 ed era 2.5 ma nell'editor 5.5
	public float m_jumpHeight = 25.0f;

	private float m_horizontal;
	private float m_vertical;

	private static bool InTheFuture;
	// This variable remain true when the player is in future

	private Transform _transform;
	private Animator _animator;
	private Rigidbody2D _rigidbody;
	private BoxCollider2D _boxcoll;

	private float nextTime=0.0f;
	private SpriteRenderer _playerSpriteRenderer;

	public Transform _ResidueTransform;
	private Collider2D [] obj;

	private Vector2 _rayOrigin;



	// Use this for initialization
	void Start () {
		// Debug.Log ("I AM " + gameObject.name);
		InTheFuture=true;
		// _animator = GetComponent<Animator>() as Animator;
		_transform = GetComponent<Transform>() as Transform;
		_animator = GetComponent<Animator>() as Animator;
		_rigidbody = GetComponent<Rigidbody2D>() as Rigidbody2D;
		_animator.SetInteger("FutureState",0);
		// nextTime=0.0f;
		// state = State.Idle;

		_playerSpriteRenderer = GetComponent<SpriteRenderer> ();

		_boxcoll = GetComponent<BoxCollider2D> ();


	}

	bool isGrounded(){
		
		return Physics2D.Raycast (_rayOrigin, Vector2.up, 0.5f);


	}
	
	// Update is called once per frame
	void Update () {	
		m_horizontal = Math.Sign(Input.GetAxis ("Horizontal"));
		m_vertical = Math.Sign(Input.GetAxis ("Vertical"));	



		if(InTheFuture==true){
			
			if (Input.GetAxis("Horizontal")<0) {
				//Debug.Log("LEFT");
				_animator.SetInteger("FutureState",1);
			}else if (Input.GetAxis("Horizontal")>0) {
				//Debug.Log("RIGHT");
				_animator.SetInteger("FutureState",2);
			}else{
				_animator.SetInteger("FutureState",0);
			}

			_transform.position = _transform.position +
				_transform.right * m_horizontal * m_speed * Time.deltaTime +
				_transform.up * m_vertical * m_speed * Time.deltaTime;
		}else{	
			// if (Input.GetAxis("Vertical")<0){
			// 	Debug.Log(Input.GetAxis("Vertical"));
			// 	_animator.SetInteger("PastState",2);
			// }else if (Input.GetAxis("Horizontal")<0) {
			// 	_animator.SetInteger("PastState",1);
			// }else if (Input.GetAxis("Horizontal")>0) {
			// 	_animator.SetInteger("PastState",3);
			// }else{
			// 	_animator.SetInteger("FutureState",0);
			// }
			if (m_vertical<0){
				//Debug.Log(m_vertical);
				_animator.SetInteger("PastState",2);
			}else{
				if(Input.GetAxis("Horizontal")==0){
					_animator.SetInteger("PastState",0);
				}else if (Input.GetAxis("Horizontal")<0) {
					_animator.SetInteger("PastState",1);
				}else if (Input.GetAxis("Horizontal")>0) {
					_animator.SetInteger("PastState",3);
				}
			}

			_transform.position = _transform.position +
			_transform.right * m_horizontal * m_speed * Time.deltaTime;
			 	//_transform.up * m_vertical * m_jumpHeight * Time.deltaTime;

			_rayOrigin = new Vector2(_boxcoll.bounds.center.x, _boxcoll.bounds.max.y + 0.02f);

			if(Input.GetKeyDown (KeyCode.DownArrow) && isGrounded()){
					_rigidbody.AddForce (new Vector2 (0, -m_jumpHeight), ForceMode2D.Impulse);
			}

		}
			

		if (Input.GetKeyDown (KeyCode.J)) {

			obj = Physics2D.OverlapCircleAll (_ResidueTransform.position, 0.3f);

			if (obj.Length == 1) {

				// Debug.Log(nextTime+"!@#");
				nextTime = Time.time + 1.0f;
				// Debug.Log("TIME TRAVEL! next time is "+nextTime+" now Time is: "+Time.time);

				InTheFuture = !InTheFuture;

				if (InTheFuture == true) {
					_rigidbody.gravityScale = 0;
					_animator.SetTrigger ("TravelToFuture");
					SoundManager.Instance.PastTravelToFuture ();
				} else {
					_rigidbody.gravityScale = -1;
					_animator.SetTrigger ("TravelToPast");
					SoundManager.Instance.FutureTravelToPast ();
				}
				
				SoundManager.Instance.SwitchBGM1 (InTheFuture);
				_rigidbody.Sleep ();

				Vector3 playerPositionNow = _transform.position;
				_transform.position = new Vector3 (playerPositionNow.x, -playerPositionNow.y, playerPositionNow.z);
				//_transform.Rotate (0, 180, 180);
				bool aa = _playerSpriteRenderer.flipY;

			
				// Press J to Switch to another gravity System
			}
		}


		if ((Time.time>nextTime)&&(nextTime!=0.0f)){
			SoundManager.Instance.SwitchBGM2(InTheFuture);
			nextTime=0.0f;
		}
		
	}

	public static bool GetFuture(){
		return InTheFuture;
	}
		
}
