using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	
	public void RestartGame() {
        SceneManager.LoadScene("LevelOne");
	}
	
	
	public void QuitGame() {
        Debug.Log("Quitting game.");
        Application.Quit();
	}
}
