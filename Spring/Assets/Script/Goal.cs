using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// プレイヤーがゴールに衝突したら
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Player") {
			// タイマーを止めて保存
			Transform timerObject = gameObject.transform.Find ("Timer");
			if (timerObject) {
				timerObject.GetComponent<Timer> ().saveStageTime ("stage_1");
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
