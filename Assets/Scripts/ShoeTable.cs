using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoeTable : Interaction   		// The table GUI functions 
{
	public MovementLocker movementLocker;	// reference to the movement locker
	public Animator animator;				// reference to the animator
	
	// reference to the input fields
	public InputField ltext;		
	public InputField ctext;			
	
	// references to the four text fields that display the numbers on the table variable names should be intuitive
	public Text leatherAvailable;			
	public Text clothAvailable;
	public Text bootsMade;
	public Text sneakersMade;
	
	// calling the interact here opens the Table GUI
    public override void Interact()
	{
		OpenWorkingTable();
	}
	
	// lock the player movement and display the table
	void OpenWorkingTable()
	{
		movementLocker.lockMovement();
		animator.SetBool("IsUsed", true);
	}
	
	// send the input field variables to the Inventory, close the table GUI and unlock player movement
	public void CloseWorkingTable()
	{
		if(ltext.text != "")
			Inventory.LeatherToUse = int.Parse(ltext.text);
		if(ctext.text != "")
			Inventory.ClothToUse = int.Parse(ctext.text);
		animator.SetBool("IsUsed", false);
		movementLocker.unlockMovement();
	}
	
	// these two methods convert the input to the maximum available if it exceeds the available resource
	public void RecalculateL()
	{
		if(int.Parse(ltext.text) > Inventory.Leather.Ammount)
			MaxLeather();
	}
	
	public void RecalculateC()
	{
		if(int.Parse(ctext.text) > Inventory.Cloth.Ammount)
			MaxCloth();
	}
	
	// the following four methods clear or replace the input with the maximum available valie for convenience
	public void ClearLeather()
	{
		ltext.text = "";
	}
	
	public void MaxLeather()
	{
		ltext.text = Inventory.Leather.Ammount.ToString();
	}
	
	public void ClearCloth()
	{
		ctext.text = "";
	}
	
	public void MaxCloth()
	{
		ctext.text = Inventory.Cloth.Ammount.ToString();
	}
	
	// Update the numbers on the table with the actua values for resources and produce
	void Update()
	{
		leatherAvailable.text = "/ " + Inventory.Leather.Ammount.ToString();
		clothAvailable.text = "/ " + Inventory.Cloth.Ammount.ToString();
		bootsMade.text = Inventory.Boots.Ammount.ToString();
		sneakersMade.text = Inventory.Sneakers.Ammount.ToString();
	}
	
}
