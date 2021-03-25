using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Spawn sender;
    public Spawn reciever;
    public float waitTime;


    //TODO: move this code ONTO the messages themselves
    //start functionality where when a sender message is selected a 
    //reciever message responds
    /* private void OnMouseDown() //this doesnt work unless ON the object
     {
         Debug.Log("press down");
         sender.spawnNow = true;
         StartCoroutine("WaitSpawnTimes");
     }

     private void OnMouseUp()
     {
         reciever.spawnNow = true;
         StartCoroutine("WaitSpawnTimes");
     }*/

    //test function
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click");
            sender.spawnNow = true;
            StartCoroutine("WaitSpawnTimes");

        } else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("release");
            reciever.spawnNow = true;
            StartCoroutine("WaitSpawnTimes");
        }

    }

    IEnumerator WaitSpawnTimes()
    {
        yield return new WaitForFixedUpdate();//huh ive never used this but its nice and makes the code go
        sender.spawnNow = false;
        reciever.spawnNow = false;
        yield return new WaitForSeconds(waitTime);
    }

    //ATM not working idk why :shrug:!
    //TODO: input functionality unhinged from Spawn script
    //INK integration https://www.youtube.com/watch?v=YW4YdsBtC38&list=PLlXuD3kyVEr5V8bK9TnEptHgoa_mYMTjb&index=2 
   
}
