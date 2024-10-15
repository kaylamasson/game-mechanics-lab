using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSprite : MonoBehaviour

{

    public string left; 
    public string right; 
    public string up;
    public string down;
    public Rigidbody2D myRigid; 

    public ParticleSystem myPart;

    // Start is called before the first frame update
    void Start()
    {
        myPart = GameObject.Find("engine").GetComponent<ParticleSystem>();
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(Input.GetKey(up)){
        myRigid.AddForce(this.transform.up * 2);
        myPart.Play();

       } else {
            myPart.Stop(); 
        }
       

       if (Input.GetKey(down)){
        myRigid.AddForce(this.transform.up * -2);
       }

        if (Input.GetKey(left)) {
            this.transform.Rotate(new Vector3(0f,0f,100f) * Time.deltaTime);
        }

        if (Input.GetKey(right)) {
            this.transform.Rotate(new Vector3(0f,0f,-100f) * Time.deltaTime);
        }
    }
}
