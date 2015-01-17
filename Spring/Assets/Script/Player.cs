using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10;
	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI() {
		if (Event.current.type == EventType.MouseDown) {
			Vector2 direction = new Vector2 (1, 1).normalized;
			rigidbody2D.velocity = direction * speed;
		}
	}
}
