using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsteroid : MonoBehaviour
{

    public int rotz; 
    public int mx, my; 
    public Rigidbody2D  myRigid; 

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        myRigid.AddForce(Vector3.up * my);
        myRigid.AddForce(Vector3.right * mx);
        myRigid.AddTorque(rotz);   
           
    }

    // Update is called once per frame
    void Update()
    {

      
    }
}
