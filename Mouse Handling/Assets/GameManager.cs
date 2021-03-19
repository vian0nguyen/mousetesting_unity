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
    //TODO: make work baby
    private void OnMouseDown()
    {
        spawner.spawnNow = true;
    }

    private void OnMouseUp()
    {
        spawner.spawnNow = true;
    }
}
