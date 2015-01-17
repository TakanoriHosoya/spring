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
			this.gameObject.transform.position = new Vector3 (0f, playerObject.transform.position.y + 4f,-10f);
		}
	
	}
}
