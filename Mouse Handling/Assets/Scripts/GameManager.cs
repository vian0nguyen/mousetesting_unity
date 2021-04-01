using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Spawn sender;
    public Spawn reciever;
    public float waitTime;

    public bool selected;

    public int spawnSenderNum;
    public int spawnRecieverNum; 


    //test function
    public void Update() //TODO: move UI 
    {
        if (Input.GetMouseButtonUp(0))
        {
            spawnRecieverNum++;
           // Debug.Log("release");
            reciever.spawnNow = true;
            sender.CreateText("words");//test 

            StartCoroutine("WaitSpawnTimes");
        }

    }

    IEnumerator WaitSpawnTimes()
    {
        Debug.Log("waiting");
        yield return new WaitForFixedUpdate();//huh ive never used this but its nice and makes the code go
        sender.spawnNow = false;
        reciever.spawnNow = false;
        yield return new WaitForSeconds(waitTime);
    }

    //INK integration https://www.youtube.com/watch?v=YW4YdsBtC38&list=PLlXuD3kyVEr5V8bK9TnEptHgoa_mYMTjb&index=2 
   
}
