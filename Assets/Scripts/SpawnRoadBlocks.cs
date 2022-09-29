using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoadBlocks : MonoBehaviour
{
    public GameObject log;
    public GameObject boulder;
    public GameObject carObstacle;
    private float spawnTime;

    public static float currSpawnTime = .5f;

    public float topLocation;
    public float bottomLocation;


    public int randomSeed = 100;
    public float minSpawnTime;
    public float maxSpawnTime;


    private int num;

    private int logNum = 0;
    private int boulderNum = 1;
    private int carObstacleNum = 2;


    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(randomSeed);
        currSpawnTime = maxSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("1");
        Debug.Log(currSpawnTime);
        if (currSpawnTime >= 0.0f)
        {
            currSpawnTime -= Time.deltaTime;
            return;
        }
        Debug.Log("2");
        int num = Random.Range(0, 3);
        if (num == logNum)
        {
        currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        Vector3 location = Vector3.zero;
    location.x = transform.position.x;
        location.y = Random.Range(bottomLocation, topLocation);
        GameObject newLog = Instantiate(log, location, Quaternion.identity);
            }
        else if(num == boulderNum)
        {
            currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Vector3 location = Vector3.zero;
            location.x = transform.position.x;
            location.y = Random.Range(bottomLocation, topLocation);
            GameObject newPotHole = Instantiate(boulder, location, Quaternion.identity);
        }
        else if (num == carObstacleNum)
        {
            currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Vector3 location = Vector3.zero;
            location.x = transform.position.x;
            location.y = Random.Range(bottomLocation, topLocation);
            GameObject newCarObstacle = Instantiate(carObstacle, location, Quaternion.identity);
            //newCarObstacle.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 500);
        }



        //currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        //Vector3 location = Vector3.zero;
        ////The GO is suppose to be on the right hand side of the screen
        //location.x = transform.position.x;
        //location.y = Random.Range(bottomLocation, topLocation);

        //GameObject newAsteroid = Instantiate(asteroid, location, Quaternion.identity);

        //float randForce = Random.Range(minForce, maxForce);
        //newAsteroid.GetComponent<Rigidbody2D>().AddForce(Vector3.left * randForce);

        //float randTorque = Random.Range(minTorque, maxTorque);
        //newAsteroid.GetComponent<Rigidbody2D>().AddTorque(randTorque);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "backWall")
        {
            Destroy(collision.gameObject);
        }
        
    }
}
