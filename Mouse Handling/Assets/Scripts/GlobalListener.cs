// This shows how an object can listen to mouse events globally. You'll need to
// do this if you are interested in events outside of a collider, or if you want
// to listen to mouse buttons besides the left mouse button.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalListener : MonoBehaviour
{
	// Which mouse button we listen to clicks of--left button is 0, right button is 1.
	public int mouseButton = 1;

	// Which prefab we'll copy when the mouse button is clicked.
	public GameObject prefab;

	// Update is called once per frame
	void Update()
	{
		Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		// It is tempting to assign transform.position directly to mousePoint.
		// This will cause the object to disppear, because its z value will be
		// incorrect.

		transform.position = new Vector3(mousePoint.x, mousePoint.y, transform.position.z);

		// This works exactly like Input.GetButtonDown() does, in that it only
		// is true for a single frame per mouse button click.

		if (Input.GetMouseButtonDown(mouseButton))
		{
			Object.Instantiate(this.prefab, new Vector3(mousePoint.x, mousePoint.y, transform.position.z), Quaternion.identity);
		}
	}
}
