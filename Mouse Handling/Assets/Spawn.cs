using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnObject;
    public bool spawnNow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnNow == true)
        {
            SpawnIt();
        }
    }

    void SpawnIt()
    {
        for (int i = 0; i < 1; i++) //if you dont do this it spawns a billion at once lol
        {
            Instantiate(spawnObject);
        }
            
    }
}
