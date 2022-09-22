using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


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
        
        newWhiteStrip1.GetComponentInChildren<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("strips");
        newWhiteStrip2.GetComponentInChildren<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("strips");
      

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "backWall")
        {
            Destroy(collision.gameObject);
        }
        //else if (collision.gameObject.tag == "Laser")
        //{
        //    GameObject newBoom = Instantiate(explode, transform.position, Quaternion.identity);
        //    Destroy(newBoom, 0.5f);
        //    Destroy(collision.gameObject);//Destroys the laser
        //    sceneManager.SendMessage("AddPoints");
        //    Destroy(this.gameObject);
        //}
    }





}
