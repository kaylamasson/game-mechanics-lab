using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BlackHole : MonoBehaviour
{

    public string whereToGo; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0,0,1f));
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject gob = collision.gameObject;
        Rigidbody2D colrig;

        if (gob.tag == "Asteroid")
        {
            colrig = gob.GetComponent<Rigidbody2D>();

            //colrig.AddForce(this.gameObject.transform.up * 100);
            colrig.AddTorque(Random.Range(-10,10));
        }

        if(gob.tag == "Player")
        {
            SceneManager.LoadScene(whereToGo); 
        }
    }
}
