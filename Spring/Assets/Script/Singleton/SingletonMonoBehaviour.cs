using UnityEngine;

public class SingletonMonoBehaviour<TYPE> : MonoBehaviour where TYPE : MonoBehaviour
{
	/**
	 * これを継承するとシングルトンパターンが実装できるそうです。
	 * Destroyは利用側で実装してください。
	 */

	private static TYPE instance;

	public static TYPE Instance {
		get {
			if (instance == null) {
				instance = (TYPE)FindObjectOfType(typeof(TYPE));

				if (instance == null) {
					Debug.LogError(typeof(TYPE) + "is nothing");
				}
			}

			return instance;
		}
	}
}
