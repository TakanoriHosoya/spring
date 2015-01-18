using UnityEngine;
using System.Collections;

public class Select  : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Player.playerState = (int)Define.StateArray.STATE_READY;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
