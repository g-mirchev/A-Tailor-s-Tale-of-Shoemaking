using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
	private bool a = false;
	private bool b = false;
	public bool madeChoice = false;
	
	public Text textQ;
	public Text textA;
	public Text textB;
	
	public Animator animator;
	public MovementLocker movementLocker;
	GameObject caller;
	
	public void StartChoice(GameObject c, string question, string choiceA, string choiceB)
	{
		caller = c;
		textQ.text = question;
		textA.text = choiceA;
		textB.text = choiceB;
		movementLocker.lockMovement();
		animator.SetBool("IsChoosing", true);
	}
	
	private void makeChoice()
	{
		movementLocker.unlockMovement();
		animator.SetBool("IsChoosing", false);
		madeChoice = true;
	}
	
    public void ChoiceA() 
	{
		a = true;
		b = false;
		makeChoice();
		caller.GetComponent<Interaction>().Consequence("A");
	}
	
	public void CboiceB() 
	{
		b = true;
		a = false;
		makeChoice();
		caller.GetComponent<Interaction>().Consequence("B");
	}
}
