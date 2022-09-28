using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling;
using UnityEngine;
using UnityEngine.UI;


public class updateDistance : MonoBehaviour
{
    public Text txt;
    public bool playing = true;
    public float timeSince;
    // Start is called before the first frame update
    void Start()
    {
        timeSince = 0.0f;
    }

    // Update is called once per frame
    private int i = 1;
    private int numFrames = 0;
    void Update()
    {
        
        if(numFrames == 11)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = i.ToString();
            i++;
            numFrames = 0;

        }
        numFrames++;



    }




}
