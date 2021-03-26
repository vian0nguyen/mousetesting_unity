using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remain : MonoBehaviour
{
    public GameManager gm;
    public float WaitDestroy;

    private void OnTriggerStay2D(Collider2D other)
    {
        if(gm.selected == true)
        {
            StartCoroutine("NonChoice"); //this doesnt work
            Destroy(other.gameObject);
        }
    }

    //TODO: maybe set a variable to set true when the other bubble leaves
    //get the trigger zone to delete the thing its colliding with (the other choice)

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("something do be gone now"); //this prints
    }

    IEnumerator NonChoice()
    {
        Debug.Log("Waiting to destroy..");
        yield return new WaitForSeconds(WaitDestroy);

    }
}
