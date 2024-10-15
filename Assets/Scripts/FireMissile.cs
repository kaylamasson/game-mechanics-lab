using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireMissile : MonoBehaviour
{

    public string fire; 
    public int speed;

    public Rigidbody2D rb;
    public GameObject prefab; 
    public Vector3 pos;
    public GameObject ship;

    public float time = 1f; 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
    time += Time.deltaTime; 

    GameObject bullet;

    //if fire key pressed
    if (Input.GetKey(fire)){
        //one bullet can be fired per second 
        if (time > 1) { 

            //instaniate bullet
            bullet = Instantiate(prefab, transform.position, transform.rotation);

            //destroy after 3 secs
            Destroy(bullet,3f);

            //reset time
            time = 0; 
        }

    }

    }

}
