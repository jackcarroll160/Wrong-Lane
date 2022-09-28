using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carDriveSceneManager : MonoBehaviour
{

   public float distance;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AddDistance();
        
    }
    void AddDistance()
    {
        distance ++;
    }


}
