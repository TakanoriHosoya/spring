﻿using UnityEngine;
using System.Collections;

public class Title {

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
			Application.LoadLevel ("SceneSelect");
		}
	}
}