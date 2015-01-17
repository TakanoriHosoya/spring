using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10;
	public GameObject player;
	public int playerState = 0;

	private Vector2 selfGravity = new Vector2(0, -3.0f);

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (playerState == 1) {
			rigidbody2D.AddForce (selfGravity);
		}
	}

	void OnGUI() {
		if (Event.current.type == EventType.MouseDown) {
			if (playerState == 0) {
				Vector2 direction = new Vector2 (1, 1).normalized;
				rigidbody2D.velocity = direction * speed;
				playerState = 1;
			}
		}
	}
}
