using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
   private Rigidbody2D myRigid; 
   public GameObject myPart;

   public float particleDuration = 0;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

     myRigid.AddForce(this.transform.up * 50);

    }

    void OnCollisionEnter2D(Collision2D collision){
        GameObject part;

        if (collision.gameObject.tag == "Asteroid"){
            particleDuration += Time.deltaTime; 
            part = Instantiate(myPart, this.transform.position, this.transform.rotation);
            Destroy(collision.gameObject);

            
        }

        Destroy(this.gameObject);
    }
}
