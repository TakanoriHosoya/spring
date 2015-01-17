using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public GameObject playerObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// プレイヤーの速度ベクトルに対して背景が動くように
		float y = Mathf.Repeat (Time.time * playerObject.rigidbody2D.velocity.y * 0.1f, 1);
		Debug.Log (playerObject.rigidbody2D.velocity.y);

		// Yの値がずれていくオフセットを作成
		Vector2 offset = new Vector2 (0, y);

		// マテリアルにオフセットを設定する
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
	
	}
}
