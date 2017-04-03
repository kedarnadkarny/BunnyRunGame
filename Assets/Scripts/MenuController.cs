using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public Text txtBestScore;

	// Use this for initialization
	void Start () {
        txtBestScore.text = PlayerPrefs.GetFloat("BestScore", 0).ToString("0.0");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
