﻿using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	// Quits the player when the user hits escape
	void Update () {
		if (Input.GetKey ("escape")) {
			Application.Quit();
		}
	}
}
