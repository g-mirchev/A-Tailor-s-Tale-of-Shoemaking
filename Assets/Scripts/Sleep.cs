using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleep : Interaction 		// The functions that transition to the next day
{
	
	public override void Interact()
	{
		FindObjectOfType<ChoiceManager>().StartChoice(this.gameObject, "Sleep?", "Yes Zzz...", "Not Yet");
	}
	
	//When the player cooses to sleep the crafting methods get executed
	public override void Consequence(string c)
	{
		switch (c)
		{
			case "A": //sleep
				Inventory.CraftBoots();
				Inventory.CraftSneakers();
				Timeline.NextDay();
				break;
			case "B": // don't sleep
				Debug.Log("No sleep yet");
				break;
		}
	}
}
