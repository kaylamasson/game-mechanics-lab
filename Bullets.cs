using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullets : MonoBehaviour
{

    public float speed;

    //public int score;
    //public Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>(); 
        

    }

    void OnTriggerEnter2D(Collider2D collision){
        //score++;

        //destroy game object if collision detected
        Destroy(gameObject);

        //hit if bullet collides with asteroid
        if (collision.gameObject.CompareTag("Asteroid")){
            print("Hit!"); 
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //move bullet 
        transform.Translate(transform.up * speed * Time.deltaTime);

        
    }
}