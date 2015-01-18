using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float time 	   = 0f;
	public bool  stopFlag  = true;

	private GameObject TimerFormat;	// テキスト切り替え用でオブジェクト生成
	Text timerFormat;				// テキスト切り替え用

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);

		// 変更するテキストを指定
		TimerFormat= GameObject.Find("Canvastimer/Timer");
		timerFormat = TimerFormat.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.stopFlag) {
			return;
		}
		this.time += Time.deltaTime;
		timeFormatISS();
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

	/**
	 * タイマーを00:00:00に変換 分:秒:ミリ秒
	 */
	public void timeFormatISS() {
		timerFormat.text = string.Format("{0:00}:{1:00}:{2:00}",
		                               Mathf.Floor(this.time / 60f),
		                               Mathf.Floor(this.time % 60f),
		                               Mathf.Floor(this.time % 1 * 100));
	}

	// ステージ番号とタイムを保存
	public void saveStageTime(string stage){
		this.stopTimer ();
		PlayerPrefs.SetFloat (stage, this.time);
		PlayerPrefs.Save ();
	}
}
