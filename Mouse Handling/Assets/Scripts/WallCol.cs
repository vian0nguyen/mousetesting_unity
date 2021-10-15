using System.Collections;
using System.Collections.Generic;
// This shows how most of the mouse-related events in MonoBehaviour work.

using UnityEngine;

public class WallCol : MonoBehaviour
{
	SpriteRenderer sprite;

	public float colorOverR;
	public float colorOverG;
	public float colorOverB;

	public float colorOutR;
	public float colorOutG;
	public float colorOutB;
	public bool test;

	void Start()
	{
		sprite = GetComponent<SpriteRenderer>();
		Vector4 colorOver = new Color(colorOverR, colorOverG, colorOverB); // cant figure out setting a public vector and convering to color
		Vector4 colorOut = new Color(colorOutR, colorOutG, colorOutB);
	}

	// It can be confusing to see all these methods working at once. Try
	// commenting out everything below so that you can see one at a time.

	// This only works if the game object this behavior is attached to also has
	// a collider. It does not need a rigidbody--but if you want it to detect
	// collisions with other game objects, it needs one like usual.

	void OnMouseEnter()
	{
		// Called once, when the cursor enters the collider.

		sprite.color = new Color(colorOverR, colorOverG, colorOverB);
	}

	void OnMouseOver()
	{
		// Called every frame the cursor is inside the collider.

		sprite.color = new Color(colorOverR, colorOverG, colorOverB);
	}

	void OnMouseExit()
	{
		// Called once, when the cursor leaves the collider.
		//sprite.color = Color.colorOut; // testing out a more flexible heirarchy driven way to change color
		//sprite.color = Color.black;
		sprite.color = new Color(colorOutR, colorOutG, colorOutB);
	}
}
