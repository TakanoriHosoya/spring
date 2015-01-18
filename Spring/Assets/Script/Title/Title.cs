using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	public AudioClip touchSE;
	public GameObject bgmManager;

	private bool coFlag = false;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		// tapされたかどうか
		if (Input.touchCount > 0) {
			// tapされたのでScene遷移
			//Application.LoadLevel ("SceneSelect");
			//FadeManager.Instance.LoadLevel("SceneSelect",1.0f);
			if (!this.coFlag) {
				StartCoroutine ("startEvent");
			}
		}

		if (Input.GetMouseButtonDown(0)) {
			// tapされたのでScene遷移
			//Application.LoadLevel ("SceneSelect");
			//FadeManager.Instance.LoadLevel("SceneSelect",1.0f);
			if (!this.coFlag) {
				StartCoroutine ("startEvent");
			}
		}
	}

	// ゲーム開始
	private IEnumerator startEvent(){
		this.coFlag = true;

		// SE
		this.audio.PlayOneShot (touchSE);

		if (bgmManager) {
			bgmManager.audio.Stop ();
		}
		yield return new WaitForSeconds (1f);
		FadeManager.Instance.LoadLevel("SceneSelect",1.0f);
	}
}
