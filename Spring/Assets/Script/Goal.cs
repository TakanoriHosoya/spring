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
		Application.LoadLevel ("SceneResult");
	}
}
