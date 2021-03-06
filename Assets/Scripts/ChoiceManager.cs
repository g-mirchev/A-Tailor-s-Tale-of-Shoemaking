﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour		//a custom choice manager 
{
	public bool madeChoice = false;
	
	public Text textQ;
	public Text textA;
	public Text textB;
	
	public Animator animator;
	GameObject caller;
	
	// This makes a pop up appear with a question and two answers, also has a reference to the instance calling the choice so a consequence method can be called
	public void StartChoice(GameObject c, string question, string choiceA, string choiceB)
	{
		caller = c;									// this is the instance that is calling the Choice method
		textQ.text = question;
		textA.text = choiceA;
		textB.text = choiceB;
		FindObjectOfType<MovementLocker>().LockMovement();				// locking the movement again
		animator.SetBool("IsChoosing", true);
	}
	
	// This closes the pop up and unlocks the player movement;
	private void makeChoice()
	{
		FindObjectOfType<MovementLocker>().UnlockMovement();
		animator.SetBool("IsChoosing", false);
		madeChoice = true;
	}
	
	// These are mapped to the buttons on the Choice pop up, after a choice is made a consequence response is sent to the instance that called the choice
    public void ChoiceA() 
	{
		makeChoice();
		caller.GetComponent<Interaction>().Consequence("A");
	}
	
	public void CboiceB() 
	{
		makeChoice();
		caller.GetComponent<Interaction>().Consequence("B");
	}
}
