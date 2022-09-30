using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class updateDistance : MonoBehaviour
{
    public Text txt;
    public bool playing = true;
    public float timeSince;
    public static int highScore;
    // Start is called before the first frame update
    void Start()
    {
        timeSince = 0.0f;
    }

    // Update is called once per frame
    public static int i = 1;
    public static bool check = true;
    private int numFrames = 0;
    void Update()
    {
        
        if(numFrames == 11 && check)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = i.ToString();
            i++;
            numFrames = 0;

        }
        numFrames++;

        

        
    }

    









}
