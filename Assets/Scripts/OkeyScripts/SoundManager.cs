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
	public AudioSource as_bgm;
	public AudioClip ac_bgm_future;
	public AudioClip ac_bgm_past;

	public int startingPitch = 4;
    public int timeToDecrease = 5;
	
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
		as_bgm.clip = ac_bgm_future;
		as_bgm.Play();
	}

	public void FutureTravelToPast(){
		as_player.PlayOneShot(ac_travel_to_past);
	}

	public void PastTravelToFuture(){
		as_player.PlayOneShot(ac_travel_to_future);
	}

	public void SwitchBGM(bool flag){
		if (flag){
			as_bgm.clip = ac_bgm_future;
			as_bgm.Play();
		}else{
			as_bgm.clip = ac_bgm_past;
			// as_bgm.pitch=0.5f;
			as_bgm.Play();
		}
		
	}

}
