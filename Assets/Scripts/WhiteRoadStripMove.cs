using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class WhiteRoadStripMove : MonoBehaviour
{
    public float speed;
    //public GameObject whiteStrip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // whiteStrip.GetComponent<Rigidbody2D>().AddForce(Vector3.left);
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        //GetComponent<Rigidbody2D>().AddForce(Vector3.left * speed);
    }
}
