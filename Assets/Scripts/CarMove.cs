using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private float changeSpot;
    private float inputX;
    // Start is called before the first frame update
    void Start()
    {
        changeSpot = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (changeSpot == inputX)
        {
            changeSpot = inputX;
            inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");  
            Vector3 moveVect = new Vector3(inputX, inputY, 0);
            moveVect *= (moveSpeed * Time.deltaTime);
            transform.Translate(moveVect);
            Debug.Log("Hi, it got here!!!");
            if(WhiteRoadStripMove.speed > 10)
            {
                SpawnWhiteStrips.currSpawnTime = SpawnWhiteStrips.currSpawnTime * 1.001f;
                WhiteRoadStripMove.speed = WhiteRoadStripMove.speed / 1.001f;
            }
            else
            {
                SpawnWhiteStrips.currSpawnTime = SpawnWhiteStrips.currSpawnTime / 1.001f;
                WhiteRoadStripMove.speed = WhiteRoadStripMove.speed * 1.001f;
            }
        }
        else
        {
            if (Input.GetKey("d")) {
                inputX = Input.GetAxis("Horizontal");
                float inputY = Input.GetAxis("Vertical");
                Vector3 moveVect = new Vector3(inputX, inputY, 0);
                moveVect *= (moveSpeed * Time.deltaTime);
                transform.Translate(moveVect);
                Debug.Log("Hi, it got 2222 HERE!!!");
                if (WhiteRoadStripMove.speed < 40)
                {
                    SpawnWhiteStrips.currSpawnTime = SpawnWhiteStrips.currSpawnTime / 1.001f;
                    WhiteRoadStripMove.speed = WhiteRoadStripMove.speed * 1.001f;

                }
             }
            else
            {
                inputX = Input.GetAxis("Horizontal");
                float inputY = Input.GetAxis("Vertical");
                Vector3 moveVect = new Vector3(inputX, inputY, 0);
                moveVect *= (moveSpeed * Time.deltaTime);
                transform.Translate(moveVect);
                Debug.Log("Hi, it got 2222 HERE!!!");
                if (WhiteRoadStripMove.speed < 40)
                {
                    SpawnWhiteStrips.currSpawnTime = SpawnWhiteStrips.currSpawnTime * 1.001f;
                    WhiteRoadStripMove.speed = WhiteRoadStripMove.speed / 1.001f;

                }
            }








        }
    }
}
