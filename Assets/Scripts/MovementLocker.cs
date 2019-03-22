using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLocker : MonoBehaviour
{
	public void lockMovement()
	{
		Camera.main.GetComponent<CamMouseLook>().enabled = false;
		Camera.main.transform.parent.gameObject.GetComponent<PlayerController>().enabled = false;
		Cursor.lockState = CursorLockMode.None;
	}
	
	public void unlockMovement()
	{
		Camera.main.GetComponent<CamMouseLook>().enabled = true;
		Camera.main.transform.parent.gameObject.GetComponent<PlayerController>().enabled = true;
		Cursor.lockState = CursorLockMode.Locked;
	}
}
