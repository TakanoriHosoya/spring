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
		//Application.LoadLevel ("SceneSelect");
		FadeManager.Instance.LoadLevel("SceneSelect",1.0f);
	}

	public void retryButtonClick()
	{
		//Application.LoadLevel ("SceneMain");
		FadeManager.Instance.LoadLevel("SceneMain",1.0f);
	}
}
