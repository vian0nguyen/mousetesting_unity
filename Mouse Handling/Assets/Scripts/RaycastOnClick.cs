// This shows how to do hit detection globally based on a mouse click. You could
// implement this using behaviors on the target game objects instead in this
// case, but in some situations this isn't possible.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastOnClick : MonoBehaviour
{
	// Which mouse button we listen to clicks of--left button is 0, right button is 1.
	public int mouseButton = 0;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(mouseButton))
		{
			// This call is different in 3D:
			// RaycastHit hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition));
			//
			// You may not have seen Vector2.zero before. It's a Vector2 with
			// value (0, 0), so effectively we are raycasting at a single point
			// in world space.

			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if (hit)
			{
				Destroy(hit.collider.gameObject);
			}
		}
	}
}
