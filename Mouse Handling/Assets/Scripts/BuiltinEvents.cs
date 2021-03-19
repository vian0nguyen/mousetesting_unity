using System.Collections;
using System.Collections.Generic;
// This shows how most of the mouse-related events in MonoBehaviour work.

using UnityEngine;

public class BuiltinEvents : MonoBehaviour
{
	SpriteRenderer sprite;

	void Start()
	{
		sprite = GetComponent<SpriteRenderer>();
	}

	// It can be confusing to see all these methods working at once. Try
	// commenting out everything below so that you can see one at a time.

	// This only works if the game object this behavior is attached to also has
	// a collider. It does not need a rigidbody--but if you want it to detect
	// collisions with other game objects, it needs one like usual.

	void OnMouseDown()
	{
		// Only called once per click.

		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2f, transform.localScale.z);
	}

	void OnMouseUp()
	{
		// Only called once per click. If you only want this event if the mouse
		// is still over the collider, use OnMouseUpAsButton() instead.
		transform.localScale = new Vector3(transform.localScale.x * 2f, transform.localScale.y, transform.localScale.z);
	}

	void OnMouseEnter()
	{
		// Called once, when the cursor enters the collider.

		sprite.color = Color.red;
	}

	void OnMouseOver()
	{
		// Called every frame the cursor is inside the collider.

		transform.Translate(Vector2.right * 0.005f);
	}

	void OnMouseExit()
	{
		// Called once, when the cursor leaves the collider.

		sprite.color = Color.white;
	}
}
