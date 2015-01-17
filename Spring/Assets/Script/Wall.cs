using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 衝突時
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Player") {
			if (gameObject.name == "WallLeft") {
				Player.playerDirection = Define.DIRECTION_RIGHT;
			} else {
				Player.playerDirection = Define.DIRECTION_LEFT;
			}

			GameObject enterPlayer = col.gameObject;
			// ジャンプ中
			if (Player.playerState == (int)Define.StateArray.STATE_JUMP) {
				int directionX = (Player.playerDirection == Define.DIRECTION_RIGHT) ? 1 : -1;
				enterPlayer.rigidbody2D.velocity = new Vector2 (directionX * Mathf.Abs(enterPlayer.rigidbody2D.velocity.x), enterPlayer.rigidbody2D.velocity.y);
			} else if (Player.playerState == (int)Define.StateArray.STATE_CATCH_READY) {
				Player.playerState = (int)Define.StateArray.STATE_CATCH;
				enterPlayer.rigidbody2D.velocity = new Vector2 (0, 0);
				Playeranimation.type = 4;
			}
		}
	}
}
