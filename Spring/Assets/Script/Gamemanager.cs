using UnityEngine;
using System.Collections;

public class Gamemanager : MonoBehaviour {

	public int stageNum = 1;

	// Use this for initialization
	void Awake () {
		stageNum = PlayerPrefs.GetInt ("STAGE_NUM");
		if (stageNum <= 0 && stageNum > 3 ) {
			stageNum = 1;
		}

		GameObject stage = (GameObject)Instantiate(Resources.Load("Prefab/Stage_" + stageNum, typeof(GameObject)));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
