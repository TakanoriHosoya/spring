using UnityEngine;
using System.Collections;

public class StatusBar : MonoBehaviour {

	private bool stopFlag = false;

	private GameObject optionPanel;

	// Use this for initialization
	void Start () {
		Transform panel = this.transform.FindChild ("OptionPanel");
		if (panel) {
			optionPanel = panel.gameObject;
			optionPanel.SetActive (false);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void stopGame(){
		if (stopFlag) {
			Time.timeScale = 1f;
			stopFlag = false;
			optionPanel.SetActive (false);
		} else {
			Time.timeScale = 0f;
			stopFlag = true;
			optionPanel.SetActive (true);
		}
	}

	public void exitStage(){
		Application.LoadLevel ("SceneSelect");
	}
}
