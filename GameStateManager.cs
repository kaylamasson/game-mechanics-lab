using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public GameObject prefab; 

    public GameObject spaceship; 
    public int howMany; 
    public Vector3 pos; 

    // Start is called before the first frame update
    void Start()
    {

        Physics2D.IgnoreLayerCollision(6,7);

        GameObject tmpAsteroid; 

        //FireMissile fm;
        MoveAsteroid am; 

        for (int i=0; i< howMany; i++){
            tmpAsteroid = Instantiate (
                prefab,
                new Vector3(Random.Range(-9,9), Random.Range(-9,9), 0),
                Quaternion.identity
            );
    
    
            am = tmpAsteroid.GetComponent<MoveAsteroid>();

            
            am.mx = Random.Range(-8,8) * 10;
            am.my = Random.Range(-8,8) * 10;
            am.rotz = Random.Range(-3,3);

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
