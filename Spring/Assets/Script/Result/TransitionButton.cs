using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TransitionButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void selectButtonClick()
	{
		Application.LoadLevel ("SceneSelect");
	}

	public void retryButtonClick()
	{
		Application.LoadLevel ("SceneMain");
	}
}
