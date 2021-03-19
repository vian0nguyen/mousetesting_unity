﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragging : MonoBehaviour
{
	
	public float dragOpacity = 0.5f;// How transparent do we become while being dragged?
	SpriteRenderer sprite; // We'll use this to change the sprite color when it comes into contact with another collider.
	public Rigidbody2D rb2d;

	bool isDragging;// Is the player currently dragging the object around?

	// We need to remember the initial position of the mouse cursor relative to
	// the game object's transform when a drag begins. Otherwise, it will appear
	// as though the object snaps to the center of the cursor when dragged.
	Vector2 dragOffset;
	

	void Start()
	{
		sprite = GetComponent<SpriteRenderer>();
		rb2d = GetComponent<Rigidbody2D>();
	}

	void OnMouseDown()// The player is beginning to drag us. We need to remember where the cursor is relative to the object's transform.
	{ 

		isDragging = true;
		dragOffset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		sprite.color -= new Color(0f, 0f, 0f, dragOpacity);// Make the sprite translucent.
	}

	// We could use an Update() method that checks the isDragging property, but
	// that would be inefficient. We use OnMouseDrag() to get notified only when
	// the mouse button is held down and the mouse has moved.

	void OnMouseDrag()
	{
		// Move so that the object is at the same position relative to the
		// cursor's position. Note that we retain the z position--forgetting
		// this can cause the game object to disappear.

		Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		transform.position = new Vector3(mousePoint.x - dragOffset.x, mousePoint.y - dragOffset.y, transform.position.z);
	}

	void OnMouseUp()
	{
		// We're done. We don't need to reset dragOffset since we only ever use
		// it during a drag.

		isDragging = false;
		sprite.color += new Color(0f, 0f, 0f, dragOpacity);
		Fall();
	}

	void Fall()
    {
		if(isDragging == false)
        {
			Debug.Log("hello?");
			rb2d.gravityScale++;
			

        }
    }
	// Remember that for these to work, the game object must have a collider and
	// rigidbody. Gravity is turned off on the object that this is attached to.
	// You may want to disable gravity in your project settings if you're never
	// planning to use it.
	//
	// In real life, you'd probably want to add an if statement checking if the
	// player is still dragging the object, so that you only take an action when
	// the player lets go of the object. In that case you might want to use
	// OnTriggerStay() instead. This gets called every frame the collider is
	// contact with a trigger.
	//
	// We create new Color objects so that we don't interfere with the opacity
	// changes related to dragging, done above.

	void OnTriggerEnter2D(Collider2D other)
	{
		sprite.color = new Color(1f, 0f, 0f, sprite.color.a);
	}

	void OnTriggerExit2D(Collider2D other)
	{
		sprite.color = new Color(1f, 1f, 1f, sprite.color.a);
	}
}