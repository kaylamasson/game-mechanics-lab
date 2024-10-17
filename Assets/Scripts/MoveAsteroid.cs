using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsteroid : MonoBehaviour
{

    public int rotz; 
    public int mx, my; 
    private Rigidbody2D myRigid; 
    private ParticleSystem myPart;
    public float startTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

        startTime = Time.timeSinceLevelLoad; 

        myRigid = this.GetComponent<Rigidbody2D>();

        myPart = this.GetComponent<ParticleSystem>(); 

        myRigid.AddForce(Vector3.up * my);
        myRigid.AddForce(Vector3.right * mx);
        myRigid.AddTorque(rotz);   
           
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    void OnCollisionEnter2D(Collision2D collision)
        {
            if (startTime + 1f < Time.timeSinceLevelLoad){
                myPart.Play();
            }
        }


    void OnCollisionExit2D(Collision2D collision)
    {
        if (startTime + 1f < Time.timeSinceLevelLoad){
            myPart.Stop();
        }
    }

    */
}
