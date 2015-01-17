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
			GameObject enterPlayer = col.gameObject;
			enterPlayer.rigidbody2D.velocity = new Vector2((-1) * enterPlayer.rigidbody2D.velocity.x, enterPlayer.rigidbody2D.velocity.y);
		}
	}
}
