using UnityEngine;
using System.Collections;

public class StageSelect : MonoBehaviour {

	public int stageNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void pushSelectButton ()
	{
		// ステージ番号を送る処理
		Debug.Log (stageNumber);

		PlayerPrefs.SetInt (Define.STAGE_NUM, stageNumber);

		//Application.LoadLevel ("SceneMain");
		FadeManager.Instance.LoadLevel("SceneMain", 1.0f);
	}
}
