using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderOnDrag : MonoBehaviour
{
    GameObject choiceObj;
    public GameManager gm;
    //public bool selected; moving to gamemanager
    public bool isDragSend;

    Vector2 dragOffset;
    Rigidbody2D rb2d;
    public float gravity;

    // Start is called before the first frame update
    void Start()
    {
        choiceObj = GameObject.FindGameObjectWithTag("Spawn1");
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() //this could need to be drag
    {
        gm.selected = true;
        isDragSend = true;
        dragOffset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }

    //also weird sender (1) doesnt respond to mouse clicking or dragging?? :shrug:
    //suspicion: it's cause sender (2) is pushed out of the choice zone?
    //unshure TODO
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
