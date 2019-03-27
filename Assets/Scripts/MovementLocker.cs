using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLocker : MonoBehaviour // a custom movement locker as parts of the game involve interacting with a GUI
{
	// locks the player movement and releases the mouse so it can be used in a 2D GUI
	public void LockMovement()
	{
		Camera.main.GetComponent<CamMouseLook>().enabled = false;
		Camera.main.GetComponent<Raycast>().enabled = false;
		Camera.main.transform.parent.gameObject.GetComponent<PlayerController>().enabled = false;
		Cursor.lockState = CursorLockMode.None;
	}
	
	// locks the cursor and unlocks the palyer movement, back to playing a first person 3D game
	public void UnlockMovement()
	{
		Camera.main.GetComponent<CamMouseLook>().enabled = true;
		Camera.main.GetComponent<Raycast>().enabled = true;
		Camera.main.transform.parent.gameObject.GetComponent<PlayerController>().enabled = true;
		Cursor.lockState = CursorLockMode.Locked;
	}
}
