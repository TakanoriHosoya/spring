using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (speed, 0, 0);
		if (this.transform.position.x > 5f) {
			this.transform.position = new Vector3 (5f, this.transform.position.y, this.transform.position.z);
			speed *= -1;
		}
		if (this.transform.position.x < -5f) {
			this.transform.position = new Vector3 (-5f, this.transform.position.y, this.transform.position.z);
			speed *= -1;
		}
	}
}
