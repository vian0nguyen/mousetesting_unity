using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOn : MonoBehaviour
{
    public Draggable draggable;


    private void OnMouseUp()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entering the zone"); 
        if(draggable.isDragging == false)//next todo is to get a game manager to see is dragging is happening
        {
            Debug.Log("will i destroy?");
            Destroy(collision.gameObject); //need to specify to destroy game object or it will only delete collider
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("stay the zone");
        if (draggable.isDragging == false)//next todo is to get a game manager to see is dragging is happening
        {
            Debug.Log("STAY will i destroy?");
            Destroy(collision.gameObject); //need to specify to destroy game object or it will only delete collider
        }
    }


}
