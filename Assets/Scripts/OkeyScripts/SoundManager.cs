using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager Instance;

	[Header("Player Source")]
	public AudioSource as_player;
	public AudioClip ac_travel_to_past;
	public AudioClip ac_travel_to_future;

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
		as_bgm_future.clip = ac_bgm_future;
		as_bgm_past.clip = ac_bgm_past;
		as_bgm_future.Play();
	}

	public void FutureTravelToPast(){
		as_player.PlayOneShot(ac_travel_to_past);
	}

	public void PastTravelToFuture(){
		as_player.PlayOneShot(ac_travel_to_future);
	}

	public void SwitchBGM1(bool InTheFuture){
		as_bgm_past.pitch=0.5f;
		as_bgm_future.pitch=0.5f;
	}

	public void SwitchBGM2(bool InTheFuture){
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
