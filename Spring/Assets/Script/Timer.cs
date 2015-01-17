using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float time 	  = 0f;
	public bool  stopFlag = true;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.stopFlag) {
			return;
		}
		this.time += Time.deltaTime;
	}

	// タイマーをスタート
	public void startTimer(){
		this.stopFlag = false;
	}

	// タイマーをストップ
	public void stopTimer(){
		this.stopFlag = true;
	}

	// タイマーをリセット
	public void resetTimer(){
		this.time = 0f;
	}

	// ステージ番号とタイムを保存
	public void saveStageTime(string stage){
		this.stopTimer ();
		PlayerPrefs.SetFloat (stage, this.time);
		PlayerPrefs.Save ();
	}
}
