using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remain : MonoBehaviour
{//MIGHT BE DEPRECATED
    public GameManager gm;
    public float WaitDestroy;
    public bool selected;
    public SenderOnDrag[] senderOnDrags;

    private void OnTriggerStay2D(Collider2D other)
    {
        if(selected == true)
        {
            StartCoroutine("NonChoice"); //this doesnt work
            Destroy(other.gameObject);//this destroys all game objects about to enter
           // Destroy(GameObject.FindGameObjectWithTag("Spawn1")); //this destroys all game objects with tag
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("something do be gone now"); //this prints
        //selected = true;//moving to senderondrag to be closer to when the event is happening
    }

    IEnumerator NonChoice()
    {
        //Debug.Log("Waiting to destroy..");
        yield return new WaitForSeconds(WaitDestroy);
        selected = false;

    }
}
