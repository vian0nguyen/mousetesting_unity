using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnObject;
    public bool spawnNow;

    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: detatch input to game manager
        //only use spawn.cs to house functionality
        //call funcationality in other scripts.
        if (Input.GetButtonDown("Jump"))
        {
            spawnNow = true;
            if(spawnNow == true)
        {
                //StartCoroutine("WaitSpawnTimes");

                Debug.Log("down");
                // Instantiate the projectile at the position and rotation of this transform
                GameObject clone;
                clone = Instantiate(spawnObject, transform.position, transform.rotation);


            }
            StartCoroutine("WaitSpawnTimes");
        }

        
    }

    /*void SpawnIt()
    {
        for (int i = 0; i < 1; i++) //if you dont do this it spawns a billion at once lol
        {
            GameObject tmp = Instantiate(spawnObject);
            
           // StartCoroutine("WaitSpawnTimes");
        }
            
    }*/


    IEnumerator WaitSpawnTimes()
    {
        spawnNow = false;
        yield return new WaitForSeconds(waitTime);
        

    }
}
