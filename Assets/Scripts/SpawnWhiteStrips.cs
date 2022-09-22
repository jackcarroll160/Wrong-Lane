using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnWhiteStrips : MonoBehaviour
{
    public GameObject whiteStrip;
    public float currSpawnTime;
    private float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = currSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime >= 0.0f)
        {
            spawnTime -= Time.deltaTime;
            return;
        }
        spawnTime = currSpawnTime;

        Vector3 location1 = Vector3.zero;
        location1.x =(float) 12.1;
        location1.y = (float)-4.18;
        




        Vector3 location2 = Vector3.zero;
        location2.x = (float)12.1;
        location2.y = (float)-1.83;

        GameObject newWhiteStrip1 = Instantiate(whiteStrip, location1, Quaternion.identity);
        GameObject newWhiteStrip2 = Instantiate(whiteStrip, location2, Quaternion.identity);
        
        newWhiteStrip1.GetComponentInChildren<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("Otherstuff");
        newWhiteStrip2.GetComponentInChildren<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("Otherstuff");
        //newWhiteStrip.GetComponent<SpriteRenderer>().
        // newWhiteStrip.GetComponent<SpriteRenderer>().sortingOrder = 2;
        //newWhiteStrip.GetComponent<SpriteRenderer>().sortingLayerID = 2;
        //    location.x = transform.position.x;
        //location.y = Random.Range(bottomLocation, topLocation);

    }
}
