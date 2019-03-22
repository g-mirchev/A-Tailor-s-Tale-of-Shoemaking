using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeTable : MonoBehaviour
{
	public MovementLocker movementLocker;
	public Animator animator;
	
    public void Interact()
	{
		OpenWorkingTable();
	}
	
	void OpenWorkingTable()
	{
		movementLocker.lockMovement();
		animator.SetBool("IsUsed", true);
	}
	
	public void CloseWorkingTable()
	{
		animator.SetBool("IsUsed", false);
		movementLocker.unlockMovement();
	}
}
