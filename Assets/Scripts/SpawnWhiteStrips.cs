using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;
using static UnityEditor.Progress;

public class SpawnWhiteStrips : MonoBehaviour
{
    public GameObject whiteStrip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 location = Vector3.zero;
        location.x = transform.position.x;
        location.y = transform.position.y;
        GameObject newWhiteStrip = Instantiate(whiteStrip, location, Quaternion.identity);
        //newWhiteStrip.GetComponentInChildren<Sp>
        newWhiteStrip.GetComponentInChildren<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("Otherstuff");
        //newWhiteStrip.GetComponent<SpriteRenderer>().
        // newWhiteStrip.GetComponent<SpriteRenderer>().sortingOrder = 2;
        //newWhiteStrip.GetComponent<SpriteRenderer>().sortingLayerID = 2;
        //    location.x = transform.position.x;
        //location.y = Random.Range(bottomLocation, topLocation);

    }
}
