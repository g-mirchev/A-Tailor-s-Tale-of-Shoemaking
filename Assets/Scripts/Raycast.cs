using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    private GameObject raycastObj;
	
	[SerializeField] private LayerMask layerMaskInteract;
	
	[SerializeField] private Image uiCrosshair;
	public Text interactText;
	
	void Update()
	{
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		
		if(Physics.Raycast(transform.position, fwd, out hit, 1.5f, layerMaskInteract.value))
		{
			if(hit.collider.CompareTag("Interactable"))
			{
				raycastObj = hit.collider.gameObject;
				interactText.text = "Press E to interact";
				if (Input.GetKeyDown("e"))
				{
					interactText.text = "";
					raycastObj.GetComponent<Interaction>().Interact();
				}
			}
		}
		else
			{
				interactText.text = "";
			}
	}
	
}
