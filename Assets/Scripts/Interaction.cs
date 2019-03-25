using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour			// the base class of interactable objects
{
	public virtual void Interact(){}				// interact can be called from Raycast
	
	public virtual void Consequence(string c) {}	// consequence is used by the choice manager
}
