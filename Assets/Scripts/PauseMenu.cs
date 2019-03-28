using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu: MonoBehaviour
{
    public GameObject pauseMenuUI;
	private Scene scene;
	public static bool GameIsPaused = false;
	
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
    }

    public void RestartGame()
	{
		Inventory.Reset();
		Timeline.Reset();
		scene = SceneManager.GetActiveScene();
		Application.LoadLevel(scene.name);
		Resume();
	}
	
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	
	void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	
	public void QuitGame()
	{
		Debug.Log("Quitting");
		Application.Quit();
	}
	
}
