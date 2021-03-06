﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MenuManagerScript : MonoBehaviour
{ 
	public GameObject pauseMenu;
	public Toggle pauseToggle;
	public Toggle fwdToggle;
	public int fwdSpeed;
	public string currentScene;
	public bool paused;
	bool muted;
	bool speeding;
	bool waiting;
	 
	void Start()
	{
		speeding = false;
		Time.timeScale = 1;
		currentScene = SceneManager.GetActiveScene().name;
		paused = false;
		muted = false;

	}

	void Update()
	{
		if (Input.GetButtonDown("Cancel"))
		{
			if (currentScene == "MainMenu")
			{
				Quit();
			}
			else if (currentScene != "MainMenu" && currentScene != "HowToPlay" && currentScene != "LevelSelection")
			{
				if (GameObject.Find("FoundationMarker").GetComponent<FoundationMarkerScript>().onBoard)
				{
					GameObject.Find("FoundationMarker").GetComponent<FoundationMarkerScript>().HideMarker();
					return;
				}
				else
				{
					GameObject.Find("Play/Pause").GetComponentInChildren<Toggle>().isOn = !GameObject.Find("Play/Pause").GetComponentInChildren<Toggle>().isOn;
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.Tab) && currentScene != "MainMenu" && currentScene != "HowToPlay" && currentScene != "LevelSelection" && !paused)
		{
			fwdToggle.isOn = !fwdToggle.isOn;
		}
	}

	public void StartGame()
	{
		SceneManager.LoadScene("LevelSelection");
	}

	public void HowToPlay()
	{
		SceneManager.LoadScene("HowToPlay");
	}



	public void Quit()
	{
		Application.Quit();
	}

	public void ContinueButton()
	{
		if (waiting) 
		{
			StartGame ();
		}
	}

	public void Pause()
	{
		if (!paused)
		{
			paused = true;
			pauseMenu.SetActive(true);
			Time.timeScale = 0;
		}
	}

	public void UnPause()
	{
		if (paused)
		{
			paused = false;
			GameObject.Find("Play/Pause").GetComponentInChildren<Toggle>().isOn = true;
			pauseMenu.SetActive(false);
			if (fwdToggle.isOn)
			{
				Time.timeScale = 1;
			}
			else if (!fwdToggle.isOn)
			{
				Time.timeScale = fwdSpeed;
			}
		}
	}

	public void GoToMain()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void Retry()
	{
        SceneManager.LoadScene(currentScene);
	}

	public void Mute()
	{
		if (!muted)
		{
			AudioListener.volume = 0;
		}
		else if (muted)
		{
			AudioListener.volume = 1;
		}
		muted = !muted;
	}

	public void PauseAndUnPause()
	{
		if (!paused)
		{
			GameObject.Find("FoundationMarker").GetComponent<FoundationMarkerScript>().HideMarker();
			Pause();
			return;
		}
		else if (paused)
		{
			UnPause();
			return;
		}
	}

	public void PauseUnPauseBugFix()
	{
		GameObject.Find("Play/Pause").GetComponentInChildren<Toggle>().isOn = !GameObject.Find("Play/Pause").GetComponentInChildren<Toggle>().isOn;
	}

	public bool GetPaused()
	{
		return paused;
	}

	public void FastForward()
	{
		speeding = !speeding;
		if (speeding)
		{
			Time.timeScale = fwdSpeed;
		}
		else if (!speeding)
		{
			Time.timeScale = 1;
		}
	}
}