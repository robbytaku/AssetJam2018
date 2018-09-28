using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


     void Update()
    {
        if (Input.GetKeyDown("r")) {
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex - 1));
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }   
    }


}
