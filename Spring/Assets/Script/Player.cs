using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static float speed = 10;
	public static int playerState     = (int)Define.StateArray.STATE_READY;
	public static int playerDirection = (int)Define.DIRECTION_RIGHT;

	public GameObject player;

	private Vector2 selfGravity  = new Vector2(0, -3.0f);

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		// ジャンプ中は重力がかかる
		if (playerState == (int)Define.StateArray.STATE_JUMP || playerState == (int)Define.StateArray.STATE_CATCH_READY) {
			rigidbody2D.AddForce (selfGravity);
		}
	}

	void OnGUI() {
		// ボタン押す処理
		if (Event.current.type == EventType.MouseDown) {
			// スタート→溜め
			if (playerState == (int)Define.StateArray.STATE_READY) {
				playerState = (int)Define.StateArray.STATE_START;
				Playeranimation.type = 2;
				// ジャンプ中→掴まり準備
			} else if (playerState == (int)Define.StateArray.STATE_JUMP) {
				playerState = (int)Define.StateArray.STATE_CATCH_READY;
			}
		} else if ((Event.current.type == EventType.MouseUp)) {
			// 射出
			if ((playerState == (int)Define.StateArray.STATE_START) || (playerState == (int)Define.StateArray.STATE_CATCH)) {
				int directionX = (playerDirection == Define.DIRECTION_RIGHT) ? 1 : -1;
				Vector2 direction = new Vector2 (directionX, 1).normalized;
				rigidbody2D.velocity = direction * speed;
				playerState = (int)Define.StateArray.STATE_JUMP;
				Playeranimation.type = 3;
			// ジャンプ中
			} else if (playerState == (int)Define.StateArray.STATE_CATCH_READY) {
				playerState = (int)Define.StateArray.STATE_JUMP;
			}
		}
	}
}
