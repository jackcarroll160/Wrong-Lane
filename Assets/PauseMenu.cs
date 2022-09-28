using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        AudioSource[] sounds = FindObjectsOfType<AudioSource>();
        foreach (AudioSource s in sounds)
            s.Play();

        GameObject d = GameObject.FindWithTag("distance");
        d.GetComponent<updateDistance>().enabled = true;

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        AudioSource[] sounds = FindObjectsOfType<AudioSource>();
        foreach (AudioSource s in sounds)
            s.Pause();

        GameObject d = GameObject.FindWithTag("distance");
        d.GetComponent<updateDistance>().enabled = false;

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void loadMenu() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit(0);
    }
}
