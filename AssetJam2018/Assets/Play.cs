﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

		private void Update() {

		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();

		if (Input.anyKeyDown)
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
	}

}

