﻿using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public GameObject timerObject;

	// Use this for initialization
	void Start () {
		timerObject = GameObject.Find("Timer");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// プレイヤーがゴールに衝突したら
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Player") {
			Player.playerState = (int)Define.StateArray.STATE_GOAL;
			int directionX = (Player.playerDirection == Define.DIRECTION_RIGHT) ? 1 : -1;
			col.gameObject.rigidbody2D.velocity = new Vector2 (directionX, 1);
			// タイマーを止めて保存
			if (timerObject) {
				int stageNum = PlayerPrefs.GetInt ("STAGE_NUM");
				if (stageNum <= 0 && stageNum > 3 ) {
					stageNum = 1;
				}
				timerObject.GetComponent<Timer> ().stopTimer ();
				timerObject.GetComponent<Timer> ().saveStageTime ("stage_" + stageNum.ToString());
			}
			StartCoroutine ("goalEvent");
		}
	}

	// ゴールしたらスローになるコルーチン
	private IEnumerator goalEvent(){
		Time.timeScale = 0.7f;
		yield return new WaitForSeconds (1.0f);
		Time.timeScale = 0.6f;
		yield return new WaitForSeconds (0.5f);
		Time.timeScale = 0.5f;
		yield return new WaitForSeconds (0.3f);
		Time.timeScale = 1f;
		Application.LoadLevel ("SceneResult");
	}
}
