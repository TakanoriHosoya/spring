using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	public AudioClip touchSE;
	public GameObject bgmManager;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		// tapされたかどうか
		if (Input.touchCount > 0) {
			// SE
			this.audio.PlayOneShot (touchSE);
			// tapされたのでScene遷移
			//Application.LoadLevel ("SceneSelect");
			//FadeManager.Instance.LoadLevel("SceneSelect",1.0f);
			StartCoroutine ("startEvent");
		}

		if (Input.GetMouseButtonDown(0)) {
			// SE
			this.audio.PlayOneShot (touchSE);
			// tapされたのでScene遷移
			//Application.LoadLevel ("SceneSelect");
			//FadeManager.Instance.LoadLevel("SceneSelect",1.0f);
			StartCoroutine ("startEvent");
		}
	}

	// ゲーム開始
	private IEnumerator startEvent(){
		if (bgmManager) {
			bgmManager.audio.Stop ();
		}
		yield return new WaitForSeconds (2f);
		FadeManager.Instance.LoadLevel("SceneSelect",1.0f);
	}
}
