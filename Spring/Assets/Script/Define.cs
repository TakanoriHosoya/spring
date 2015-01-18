using UnityEngine;
using System.Collections;

public class Define {

	// 定数定義
	public const int Test = 1;

	public enum StateArray
	{
		STATE_READY,       // 開始前
		STATE_START,       // スタート時、溜め
		STATE_JUMP,        // 跳躍中
		STATE_CATCH_READY, // 捕まる準備
		STATE_CATCH,       // 捕まる
		STATE_GOAL,        // ゴール到達
		STATE_STOP,        // 待機
		STATE_FINISH,      // ゲームオーバー
	};

	public const int DIRECTION_LEFT  = 1;
	public const int DIRECTION_RIGHT = 2;

	public const string STAGE_NUM = "STAGE_NUM";
	public const string STAGE_TIME = "stage_";
}
