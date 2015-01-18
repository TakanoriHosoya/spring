using UnityEngine;
using System.Collections;

public class Select  : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		//if (Input.touchCount > 0) {
		if (Input.GetMouseButtonDown(0)) {
		//	Debug.Log(Input.mousePosition.x);
		//	Debug.Log(Input.mousePosition.y);
		}
	}
}
