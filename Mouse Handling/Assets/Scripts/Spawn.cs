using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    public GameObject spawnObject;
    public bool spawnNow;

    public float waitTime;
    public Vector3 parentPos;
   // public GameObject child;

    public GameObject clone = null;
    public TMP_Text choiceText = null;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //GameObject clone;

        if (spawnNow == true)
        {

            clone = Instantiate(spawnObject, gameObject.transform.position, gameObject.transform.rotation);// Instantiate the projectile at the position and rotation of this transform
            //https://stackoverflow.com/questions/40752083/how-to-find-child-of-a-gameobject-or-the-script-attached-to-child-gameobject-via
            //child = clone.transform.GetChild(1).gameObject;//only finds and returns game obj
             choiceText = clone.GetComponentInChildren<TMP_Text>();//finds the component but does it do anything with it TODO


   
        }
        //take it outside and make not local to call the variable out
        Vector3 parentPos = new Vector3(clone.transform.position.x, clone.transform.position.y, transform.position.z);
        //above is only called when spawn now is true
        //this should be moved to be checking at all tiems
        //Debug.Log(parentPos);//test to see what parentPos 

    }

    public void CreateText(string text) //called in gamemanager
    {
        choiceText.text = text;
        choiceText.transform.position = new Vector3(parentPos.x, parentPos.y, transform.position.z);


    }
    
}
