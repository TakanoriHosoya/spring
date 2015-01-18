using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 衝突時
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Player") {
			GameObject enterPlayer = col.gameObject;
			enterPlayer.rigidbody2D.velocity = new Vector2 (0, 0);
			Player.playerState = (int)Define.StateArray.STATE_READY;
			enterPlayer.transform.position = new Vector3 (0, -5, -6);
			}
	}

}
