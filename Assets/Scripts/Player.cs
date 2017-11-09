using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour {

	private float m_horizontal;
	private float m_vertical;
	public float m_speed = 150.0f;
	private Transform _transform;
	private Rigidbody2D _playerRb;
	private float jumpPower = 0;
	private bool isGrounded = true;
	public RaycastHit2D hit;

	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform>() as Transform;
		_playerRb = GetComponent<Rigidbody2D> () as Rigidbody2D;
		//_twtrans = GetComponent <TweenTransforms>;
	}
	
	// Update is called once per frame
	void Update () {
		m_horizontal = Math.Sign (Input.GetAxis ("Horizontal"));
		m_vertical = Math.Sign (Input.GetAxis ("Vertical"));
		if (WorldTurn.getFuture ()) {
			_transform.position = _transform.position +
			_transform.right * m_horizontal * m_speed * Time.deltaTime +
			_transform.up * m_vertical * m_speed * Time.deltaTime;

		}else{
			_transform.position = _transform.position + _transform.right * m_horizontal * m_speed * Time.deltaTime + 
				_transform.up * m_vertical * jumpPower * Time.deltaTime;
		}
		
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "Ground") 
			isGrounded = true;

	}

	void FixedUpdate(){
		
		if (Input.GetKeyDown (KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.W) && isGrounded) {
			isGrounded = false;
			jumpPower = 7.5f;
		}
	}

}
