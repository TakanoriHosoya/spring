using UnityEngine;
using System.Collections;

public class TransitionButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		Rect rect = new Rect(50, 300, 200, 50);
		bool isClicked = GUI.Button(rect, "Go to Stage Select");
		if (isClicked)
		{
			Application.LoadLevel ("SceneSelect");
		}
	}
}
