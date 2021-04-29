using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOn : MonoBehaviour
{
    public Draggable draggable;

    public FolderScriptable fileData; //is there a way to make this the object we id below?
    //https://www.youtube.com/watch?v=2WnAOV7nHW0 // inventory system with scriptable objects (complicated?)
    //https://www.youtube.com/watch?v=d9oLS5hy0zU //inventory system add and remove using singletons and manager
    //above is a good base for system architecture
    private void OnMouseUp()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //find component https://blog.terresquall.com/2020/02/checking-the-type-of-gameobject-you-are-colliding-with-in-unity/
        //if game object has the file component do something
        if (other.GetComponent<File>()) { 
        
            //next make it pull the data and do something with it
        
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
