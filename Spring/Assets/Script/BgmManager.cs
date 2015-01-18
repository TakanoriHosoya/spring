using UnityEngine;
using System.Collections;

public class BgmManager : MonoBehaviour {

	public AudioClip mainBgm;
	public AudioClip dashBgm;

	// Use this for initialization
	void Awake () {
		//mainBgm = (AudioClip)Resources.Load ("Sound/stage");
		//dashBgm = (AudioClip)Resources.Load ("Sound/speed_up");
		//this.audio.clip = dashBgm;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.audio.isPlaying == false) {
			this.audio.Play ();
		}

	}
}
