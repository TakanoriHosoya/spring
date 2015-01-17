using UnityEngine;
using System.Collections;

/**
 * シーン遷移時のフェードイン・フェードアウトの制御クラス
 */
public class FadeManager : SingletonMonoBehaviour<FadeManager>
{
	private Texture2D blackTexture; // 暗転用テクスチャ
	private float fadeAlpha = 0;    // フェード中の透明度
	private bool isFading = false;  // フェード中フラグ

	public void Awake ()
	{
		if (this != Instance) {
			Destroy(this);
			return;
		}
	
		DontDestroyOnLoad(this.gameObject);

		// 黒テクスチャの作成
		this.blackTexture = new Texture2D (32, 32, TextureFormat.RGB24, false);
		this.blackTexture.ReadPixels(new Rect(0, 0, 32, 32), 0, 0, false);
		this.blackTexture.SetPixel(0, 0, Color.white);
		this.blackTexture.Apply();
	}

	public void OnGUI ()
	{
		if (!this.isFading) {
			return;
		}

		GUI.color = new Color(0, 0, 0, this.fadeAlpha);
		GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), this.blackTexture);
	}

	/**
	 * 画面遷移処理
	 * scene	遷移先のシーン名
	 * interval	暗転するまでの時間
	 */
	public void LoadLevel(string scene, float interval)
	{
		StartCoroutine(TransScene (scene, interval));
	}

	/**
	 * シーン遷移用コルーチン
	 */
	private IEnumerator TransScene(string scene, float interval)
	{
		this.isFading = true;
		float time = 0;

		// 暗くする
		while (time <= interval) {
			this.fadeAlpha = Mathf.Lerp(0f, 1f, time / interval);
			time += Time.deltaTime;
			yield return 0;
		}

		// シーン切り替え
		Application.LoadLevel(scene);

		// 明るくする
		time = 0;
		while (time <= interval) {
			this.fadeAlpha = Mathf.Lerp(1f, 0f, time / interval);
			time += Time.deltaTime;
			yield return 0;
		}

		this.isFading = false;
	}
}






