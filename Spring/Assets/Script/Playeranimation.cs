using UnityEngine;
using System.Collections;

public class Playeranimation : MonoBehaviour {

	// animationのフラグ管理
	public bool isWait  = false;	// 待機
	public bool isStart = false;	// スタート
	public bool isFly   = false;	// 飛んでる
	public bool isWall  = false;	// 壁にはりついてる
	
	// animationをデータを受け取るときに仕様
	public int type = 1;			// デフォルトは待機モーション

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// 初期化
		initStatus();

		// モーションの切り替え
		switch (type) {
			// 待機
			case (1):
				isWait = true;
				break;
			// ゲームスタート
			case (2):
				isStart = true;
				break;
			// 飛んでる
			case (3):
				isFly = true;
				break;
			// 壁に張り付く
			case (4):
				isWall = true;
				break;
			default:
				// 万が一何かあったらstartのモーションに
				isWait = true;
				break;
		}

		cAnimator.SetBool("isWait",  isWait);
		cAnimator.SetBool("isStart", isStart);
		cAnimator.SetBool("isFly",   isFly);
		cAnimator.SetBool("isWall",  isWall);
	}

	/****************************************
	 * 初期化処理
	 ****************************************/
	void initStatus() {
		isWait  = false;	// 待機
		isStart = false;	// スタート
		isFly   = false;	// 飛んでる
		isWall  = false;	// 壁に張り付いてる
	}

	/********************************************
	 *  以下animation再生に必要な要素
	 ********************************************/
	public Transform cTransform	{
		get {
			if(!_cTransform) {
				_cTransform = transform;
			}
			return _cTransform;
		}
	}
	Transform _cTransform;

	public Animator cAnimator
	{
		get
		{
			if(!_cAnimator)
				_cAnimator = _cAnimator ?? GetComponent<Animator>();
			return _cAnimator;
		}
	}
	Animator _cAnimator;
}