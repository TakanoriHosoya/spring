using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	// 衝突時
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Player") {
			GameObject enterPlayer = col.gameObject;
			// 方向転換
			Player _player = enterPlayer.GetComponent<Player>();
			_player.changeDirection ();
			// ジャンプ中
			int directionX = (Player.playerDirection == Define.DIRECTION_RIGHT) ? 1 : -1;
			enterPlayer.rigidbody2D.velocity = new Vector2 (directionX * Mathf.Abs(enterPlayer.rigidbody2D.velocity.x), enterPlayer.rigidbody2D.velocity.y);
		}
	}
}
