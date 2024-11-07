using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
   private Rigidbody2D myRigid; 
   public GameObject myPart;
   private GameStateManager gsm;
   public float missileSpeed;
   private float timeFired;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update()
    {

    timeFired += Time.deltaTime; 

    myRigid.AddForce(this.transform.up * missileSpeed);

    if (timeFired > 2){
        //destroy bullet after 2 secs if no collision occurs
        Destroy(this.gameObject);
    }



    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject part;

        if (collision.gameObject.tag == "Asteroid")
        {
            part = Instantiate(myPart, this.transform.position, this.transform.rotation);
            gsm.adjustScore(1);
            Destroy(collision.gameObject);  
            gsm.howMany -= 1;  

            //for (int i=0; i<2; i++)
        }

    //destroys bullet on collision
        Destroy(this.gameObject);

        //player wins if player destroys all asteroids 
        //if (gsm.howMany == 0){
          //Debug.Log("** You win! **");
        }
    }
}
