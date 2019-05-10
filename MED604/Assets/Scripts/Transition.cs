using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.I)) {
			SceneManager.LoadScene(1);
		}

		if (Input.GetKeyDown(KeyCode.O)) {
			SceneManager.LoadScene(2);
		}
	}
}
