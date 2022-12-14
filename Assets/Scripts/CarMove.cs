using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private float changeSpot;
    private float inputX;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        changeSpot = Input.GetAxis("Horizontal");
        updateDistance.i = 1;
        updateDistance.check = true;
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
            
            //if (WhiteRoadStripMove.speed > 10)
            //{
            //    SpawnWhiteStrips.currSpawnTime = SpawnWhiteStrips.currSpawnTime * 1.001f;
            //    WhiteRoadStripMove.speed = WhiteRoadStripMove.speed / 1.001f;
            //}
            //else
            //{
            //    SpawnWhiteStrips.currSpawnTime = SpawnWhiteStrips.currSpawnTime / 1.001f;
            //    WhiteRoadStripMove.speed = WhiteRoadStripMove.speed * 1.001f;
            //}
        }
        else
        {
            if (Input.GetKey("d"))
            {
                inputX = Input.GetAxis("Horizontal");
                float inputY = Input.GetAxis("Vertical");
                Vector3 moveVect = new Vector3(inputX, inputY, 0);

    
        
          
    

        
    
    

                moveVect *= (moveSpeed * Time.deltaTime);
                transform.Translate(moveVect);
               
                //if (WhiteRoadStripMove.speed < 40)
                //{
                //    SpawnWhiteStrips.currSpawnTime = SpawnWhiteStrips.currSpawnTime / 1.001f;
                //    WhiteRoadStripMove.speed = WhiteRoadStripMove.speed * 1.001f;

                //}
            }
            else
            {
                inputX = Input.GetAxis("Horizontal");
                float inputY = Input.GetAxis("Vertical");
                Vector3 moveVect = new Vector3(inputX, inputY, 0);
                moveVect *= (moveSpeed * Time.deltaTime);
                transform.Translate(moveVect);
                
                //if (WhiteRoadStripMove.speed < 40)
                //{
                //    SpawnWhiteStrips.currSpawnTime = SpawnWhiteStrips.currSpawnTime * 1.001f;
                //    WhiteRoadStripMove.speed = WhiteRoadStripMove.speed / 1.001f;

                //}
            }








        }
    }
    public AudioSource[] audio = new AudioSource[5];
   public IEnumerator soundClipThenLoad(int sound, int scene)
    {
        
        audio[sound].Play();
        //audio[sound].Play();

        yield return new WaitForSeconds(1.4f);
       
        SceneManager.LoadScene(scene);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        

        
        if (collision.gameObject.tag == "carObstacle")
        {
            this.gameObject.layer = 14;
            GetComponent<Rigidbody2D>().AddTorque(150);
            updateDistance.check = false;
            //GameObject newExplosion = Instantiate(explosion, new Vector3(this.transform.position.x, this.transform.position.y, -10 ) , Quaternion.identity);
            StartCoroutine(soundClipThenLoad(0, 4));
            
            if (updateDistance.i > PlayerPrefs.GetInt("highScore"))
            {
                //updateDistance.highScore = updateDistance.i;
                PlayerPrefs.SetInt("highScore", updateDistance.i);
                //updateDistance.i = 1;
            }

            
            
            


        }
        else if (collision.gameObject.tag == "log")
        {
            this.gameObject.layer = 14;
            GetComponent<Rigidbody2D>().AddTorque(150);
            updateDistance.check = false;
            StartCoroutine(soundClipThenLoad(2, 4));
            if (updateDistance.i > PlayerPrefs.GetInt("highScore"))
            {
                //updateDistance.highScore = updateDistance.i;
                PlayerPrefs.SetInt("highScore", updateDistance.i);
                //updateDistance.i = 1;
            }
            
        }
        else if (collision.gameObject.tag == "boulder")
        {
            this.gameObject.layer = 14;
            GetComponent<Rigidbody2D>().AddTorque(150);
            updateDistance.check = false;
            StartCoroutine(soundClipThenLoad(3, 4));
            if (updateDistance.i > PlayerPrefs.GetInt("highScore"))
            {
                
                PlayerPrefs.SetInt("highScore", updateDistance.i);
              //  updateDistance.i = 1;
            }
            
        }
        else if (collision.gameObject.tag == "grassWall")
        {
            this.gameObject.layer = 14;
            GetComponent<Rigidbody2D>().AddTorque(150);
            updateDistance.check = false;
            StartCoroutine(soundClipThenLoad(1, 4));
            if (updateDistance.i > PlayerPrefs.GetInt("highScore"))
            {
                
                PlayerPrefs.SetInt("highScore", updateDistance.i);
              //  updateDistance.i = 1;
            }
            // animation and tire deflate sound
            
            
            //SceneManager.LoadScene(4);
        }
    }













}