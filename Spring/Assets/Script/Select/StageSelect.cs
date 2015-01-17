using UnityEngine;
using System.Collections;

public class StageSelect : MonoBehaviour {

	// Use this for initialization
/*	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
*/
	void OnGUI()
	{
		Rect rect = new Rect(10, 200, 100, 100);
		bool isClicked = GUI.Button(rect, "stage-1");
		if (isClicked)
		{
			Application.LoadLevel ("SceneResult");
		}
	}
}
