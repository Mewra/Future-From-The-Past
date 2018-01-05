using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager Instance;
	private bool InTheStopTime;

	[Header("Player Source")]
	public AudioSource as_player;
	public AudioClip ac_travel;

	[Header("Player Stop TIme")]
	public AudioSource as_player_stopTime;
	public AudioClip ac_stopTime;

	[Header("Player Walk")]
	public AudioSource as_player_walk;
	public AudioClip ac_player_walk;
	// public AudioClip ac_travel_to_future;

	[Header("Soundtrack")]
	public AudioSource as_bgm_future;
	public AudioClip ac_bgm_future;

	[Header("Soundtrack")]
	public AudioSource as_bgm_past;
	public AudioClip ac_bgm_past;

	float timeStamp;

	// Use this for initialization
	void Awake () {
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	void Start(){
		as_player.clip = ac_travel;
		as_player_stopTime.clip = ac_stopTime;
		as_player_walk.clip=ac_player_walk;
		as_bgm_future.clip = ac_bgm_future;
		as_bgm_past.clip = ac_bgm_past;
		as_bgm_future.Play();
		as_player_walk.Play();
		as_player_walk.Pause();
		InTheStopTime=false;
	}

	public void FutureTravelToPast(){
		as_player.PlayOneShot(ac_travel);
	}

	public void PastTravelToFuture(){
		as_player.PlayOneShot(ac_travel);
	}

	public void LandOnTheGround(){
		as_player_walk.Play();
	}

	public void NotOnTheGround(){
		as_player_walk.Pause();
	}

	public void SwitchBGM1(bool InTheFuture){
		if (InTheStopTime){

		}else{
			as_bgm_past.pitch=0.5f;
			as_bgm_future.pitch=0.5f;
		}	
	}

	public void StopTimeBGM(){
		InTheStopTime=true;
		as_bgm_past.pitch=0.1f;
		as_bgm_future.pitch=0.1f;
		as_player_stopTime.Play();
	}

	public void StopTimeEnd(){
		as_player_stopTime.Pause();
		InTheStopTime=false;
		as_bgm_past.pitch=1.0f;
		as_bgm_future.pitch=1.0f;
	}

	public void SwitchBGM2(bool InTheFuture){
		if(InTheStopTime){
			if (InTheFuture){
				as_bgm_past.Pause();
				as_bgm_future.Play();
			}else{
				as_bgm_future.Pause();
				as_bgm_past.Play();
			}	
		}else{
			as_bgm_past.pitch=1.0f;
			as_bgm_future.pitch=1.0f;
			if (InTheFuture){
				as_bgm_past.Pause();
				as_bgm_future.Play();
			}else{
				as_bgm_future.Pause();
				as_bgm_past.Play();
			}	
		}	
	}
}
