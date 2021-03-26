using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnObject;
    public bool spawnNow;

    public float waitTime;
    public Transform parentPos;
    public GameObject textPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (spawnNow == true)
        {

            
          //  Debug.Log("now spawning");
            // Instantiate the projectile at the position and rotation of this transform
            GameObject clone;
            clone = Instantiate(spawnObject, transform.position, transform.rotation);

            //test child text spawn
           // Debug.Log("spawn text");
            GameObject textChild = Instantiate(textPrefab, parentPos);
            
        }
   
    }




    
}
