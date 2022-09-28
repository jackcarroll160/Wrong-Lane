using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void loadHowToPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void startHomeScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame() 
    {
        Application.Quit(0);
    }

    public void startCreditScene()
    {
        SceneManager.LoadScene(3);
    }


}
