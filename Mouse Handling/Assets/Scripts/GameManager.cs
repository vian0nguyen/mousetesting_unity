using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Spawn spawner;
    // Start is called before the first frame update
    /* void Start()
     {
         spawner = GameObject.GetComponent<Spawn>();
     }*/

    //ATM not working idk why :shrug:!
    //TODO: input functionality unhinged from Spawn script
    //INK integration https://www.youtube.com/watch?v=YW4YdsBtC38&list=PLlXuD3kyVEr5V8bK9TnEptHgoa_mYMTjb&index=2 
    private void OnMouseDown()
    {
        spawner.spawnNow = true;
    }

    private void OnMouseUp()
    {
        spawner.spawnNow = true;
    }
}
