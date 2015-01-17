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
		// ステージ番号を送る処理を追加
		Debug.Log (stageNumber);


		Application.LoadLevel ("SceneMain");
	}
}
