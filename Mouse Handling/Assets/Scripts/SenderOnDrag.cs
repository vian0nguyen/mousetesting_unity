using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderOnDrag : MonoBehaviour
{
    public GameObject choiceObj;
    public GameManager gm;
    //public bool selected; moving to gamemanager
    public bool isDragSend;

    Vector2 dragOffset;
    Rigidbody2D rb2d;
    public float gravity;

  //  public GameObject destroyZone;
    public bool selected;

    // Start is called before the first frame update
    void Start()
    {
      //  choiceObj = GameObject.FindGameObjectWithTag("Spawn1");
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (gm.selected == true) 
        {
            if(selected == false) //oops you were voted off the island
            {
                Debug.Log("is this happening");
                Destroy(gameObject);
            }
            
        }
    }

    private void OnMouseDown() //this could need to be drag
    {
        isDragSend = true;
        dragOffset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        selected = true;
        gm.selected = true; //send this to an outside arbiter of truth

    }

    private void OnMouseDrag()
    {
        Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePoint.x - dragOffset.x, mousePoint.y - dragOffset.y, transform.position.z);
    }
    private void OnMouseUp()
    {
        gm.selected = false;
        isDragSend = false;
        Sent();

    }


    void Sent()
    {
        if (isDragSend == false)
        {
            Debug.Log("message sent!");
            rb2d.gravityScale = gravity;


        }
    }
}
