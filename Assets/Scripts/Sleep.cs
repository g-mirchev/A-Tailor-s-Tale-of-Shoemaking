using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	
public class Sleep : Interaction 		// The functions that transition to the next day
{
	public GameObject instructions;
	public InputField ltext;
	public InputField ctext;
	
	public Animator animator;
	
	private int clothProg = 0;
	public int ClothProg
	{
		set{clothProg = value;}
		get{return clothProg;}
	}
	private int sneakerProg = 0;
	public int SneakerProg
	{
		set{sneakerProg = value;}
		get{return sneakerProg;}
	}
	private bool donateChoice = false;
	public bool DonateChoice
	{
		set{donateChoice = value;}
		get{return donateChoice;}
	}
	
	public override void Interact()
	{
		FindObjectOfType<ChoiceManager>().StartChoice(this.gameObject, "Sleep?", "Yes Zzz...", "Not Yet");
	}
	
	//When the player cooses to sleep the crafting methods get executed
	public override void Consequence(string c)
	{
		if(DonateChoice == true)
		{
			switch (c)
				{
				case "A": // donate
					Inventory.DonateSneakers();
					FindObjectOfType<StoryManager>().AddProgress(2);
					break;
				case "B": // don't donate
					FindObjectOfType<StoryManager>().AddProgress(1);
					break;
				}
			FindObjectOfType<StoryManager>().TriggerStorySleep();
			donateChoice = false;
		}
		else
		{
			switch (c)
			{
				case "A": //sleep
					FindObjectOfType<StoryManager>().MadeProgress = false; //nullify the last day's proggress tick so it can b eused for this one
					if(Inventory.Cloth.Ammount >= 15 && Timeline.Day == 4)
						ClothProg = 1;
					Inventory.CraftBoots();
					Inventory.CraftSneakers();
					ltext.text = "0";
					ctext.text = "0";
					if(Inventory.Sneakers.Ammount >= 5 && Timeline.Day == 4)
						SneakerProg = 1;
					Asleep();
					break;
				case "B": // don't sleep
					break;
			}
		}
	}
	
	public void Asleep()
	{
		FindObjectOfType<StoryManager>().AddCraftingProgress();
		animator.SetBool("IsAsleep", true);
		int prog = ClothProg + SneakerProg;
		FindObjectOfType<StoryManager>().AddProgress(prog);
		FindObjectOfType<StoryManager>().TriggerStorySleep();
	}
	
	public void WakeUp()
	{
		int i = FindObjectOfType<StoryManager>().Progress;
		switch (i)
		{
			case 1:
				Timeline.NextDay();
				animator.SetBool("IsAsleep", false);
				FindObjectOfType<Shop>().tag = "Interactable";
				FindObjectOfType<MovementLocker>().UnlockMovement();
				Timeline.InteractedT = false;
				break;
			case 3:
			case 5:
				Timeline.NextDay();
				animator.SetBool("IsAsleep", false);
				FindObjectOfType<MovementLocker>().UnlockMovement();
				Timeline.InteractedT = false;
				break;
			case 11:
				donateChoice = true;
				FindObjectOfType<ChoiceManager>().StartChoice(this.gameObject, "Give the children shoes?", "Give shoes", "Keep shoes");
				break;
			case 10:
			case 12:
			case 13:
				Timeline.NextDay();
				animator.SetBool("IsAsleep", false);
				FindObjectOfType<Shop>().tag = "Interactable";
				FindObjectOfType<Sleep>().tag = "Untagged";
				FindObjectOfType<MovementLocker>().UnlockMovement();
				Timeline.InteractedT = true;
					break;
			default:
				Timeline.NextDay();
				animator.SetBool("IsAsleep", false);
				FindObjectOfType<Shop>().tag = "Interactable";
				FindObjectOfType<MovementLocker>().UnlockMovement();
				Timeline.InteractedT = true;
				break;
		}
	}
}
