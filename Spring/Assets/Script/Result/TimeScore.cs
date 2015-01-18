using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScore : MonoBehaviour {

	public float playerTime = 0f;

	private GameObject TimerFormat;	// テキスト切り替え用でオブジェクト生成
	Text timerFormat;				// テキスト切り替え用

	// Use this for initialization
	void Start () {
		playerTime = PlayerPrefs.GetFloat (Define.STAGE_TIME + PlayerPrefs.GetInt(Define.STAGE_NUM));

		Debug.Log (playerTime);

		// 変更するテキストを指定
		TimerFormat= GameObject.Find("Canvas/Timer");
		timerFormat = TimerFormat.GetComponent<Text> ();

		timeFormatISS();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	/**
	 * タイマーを00:00:00に変換 分:秒:ミリ秒
	 */
	public void timeFormatISS() {
		timerFormat.text = string.Format("{0:00}:{1:00}:{2:00}",
		                                 Mathf.Floor(this.playerTime / 60f),
		                                 Mathf.Floor(this.playerTime % 60f),
		                                 Mathf.Floor(this.playerTime % 1 * 100));
	}
}
