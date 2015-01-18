using UnityEngine;
using System.Collections;

public class Block2 : MonoBehaviour {

	// 衝突時
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Player") {
			GameObject enterPlayer = col.gameObject;
			// ジャンプ中
			enterPlayer.rigidbody2D.velocity = new Vector2 (enterPlayer.rigidbody2D.velocity.x, (-1) * enterPlayer.rigidbody2D.velocity.y);
		}
	}

}
