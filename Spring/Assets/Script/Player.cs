using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static float speed = 10;
	private int finishCount = 100;
	public static int playerState     = (int)Define.StateArray.STATE_READY;
	public static int playerDirection = (int)Define.DIRECTION_RIGHT;

	public AudioClip jumpSe;

	private Vector2 selfGravity    = new Vector2(0, -3.0f);
	private Vector2 finishGravity  = new Vector2(0, -0.7f);

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(0, 0);

		playerState = (int)Define.StateArray.STATE_READY;
		playerDirection = (int)Define.DIRECTION_RIGHT;

	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate() {
		// ジャンプ中は重力がかかる
		if (playerState == (int)Define.StateArray.STATE_JUMP || playerState == (int)Define.StateArray.STATE_CATCH_READY) {
			rigidbody2D.AddForce (selfGravity);
		}
		// start中は初期化しておく
		if (playerState == (int)Define.StateArray.STATE_READY) {
			initPlayer();
		}
		if (playerState == (int)Define.StateArray.STATE_GOAL) {
			rigidbody2D.AddForce (finishGravity);
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
				// SE
				if (jumpSe != null) {
					audio.PlayOneShot (jumpSe);
				}
				// 矢印の消去
				if (playerState == (int)Define.StateArray.STATE_START) {
					GameObject timer = GameObject.Find ("Timer");
					if (timer != null) {
						timer.GetComponent<Timer> ().startTimer ();
					}
					Transform arrowTransform = transform.FindChild("PlayerArrow");
					if (arrowTransform != null) {
						GameObject arrow = arrowTransform.gameObject;
						Destroy(arrow);
					} 
				}

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

	public void changeDirection() {
		if (playerDirection == (int)Define.DIRECTION_RIGHT) {
			playerDirection = (int)Define.DIRECTION_LEFT;
			transform.localScale = new Vector3 (-0.5f, 0.5f, 0);
		} else {
			playerDirection = (int)Define.DIRECTION_RIGHT;
			transform.localScale = new Vector3 (0.5f, 0.5f, 0);
		}
	}

	/**********************************
	 * Playerの初期化処理
	 **********************************/
	public void initPlayer(){
		// スピード
		speed = 0;
		// Playerの状態
		playerState = (int)Define.StateArray.STATE_READY;
		// 位置を初めのところに
		this.gameObject.transform.position = new Vector3( 0.0f, -5.0f, -6.0f);
		// 移動速度を初期化
		Vector2 direction = new Vector2 (0.0f, 0.0f).normalized;
		rigidbody2D.velocity = direction * speed;
		
		// animationを待機に
		Playeranimation.type = 1;
	}
}
