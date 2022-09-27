using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadBlockCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject logs = GameObject.FindGameObjectWithTag("log");
       
        Collider2D thisCollider = GetComponent<Collider2D>();
        Collider2D[] borderColliders = logs.GetComponents<Collider2D>();
        foreach (Collider2D c in borderColliders)
            Physics2D.IgnoreCollision(thisCollider, c);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "backWall")
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "player")
        {
            //perform animation
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

}
