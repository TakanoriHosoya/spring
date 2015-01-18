using UnityEngine;
using System.Collections;

public class CharactorCamera : MonoBehaviour {

	public GameObject playerObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (playerObject) {

			if (playerObject.transform.position.y - this.gameObject.transform.position.y >= -1.0f) {
				this.gameObject.transform.position = new Vector3 (0f, playerObject.transform.position.y + 1f,-10f);
			}
			if (playerObject.transform.position.y - this.gameObject.transform.position.y <= -4.0f) {
				this.gameObject.transform.position = new Vector3 (0f, playerObject.transform.position.y + 4f,-10f);
			}
		}
	
	}
}
