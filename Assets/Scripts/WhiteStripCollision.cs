using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteStripCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "backWall")
        {
            Destroy(this.gameObject);
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
