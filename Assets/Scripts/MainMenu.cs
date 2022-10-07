using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject hScoreUI;
    //public static bool start = true;
   //public static GameObject highScoreUI;
    // Start is called before the first frame update
    void Start()
    {
        //if(start == true)
        //PlayerPrefs.SetInt("highScore", 1);
        //start = false;
        //PlayerPrefs.SetInt("highScore", 1);
    }

    // Update is called once per frame
    void Update()
    {
        hScoreUI.GetComponent<TMPro.TextMeshProUGUI>().text = (PlayerPrefs.GetInt("highScore")-1).ToString();
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
    
    //public static void updateHighScore()
   // {
     //   highScoreUI.GetComponent<TMPro.TextMeshProUGUI>().text = updateDistance.highScore.ToString();
   // }


}
