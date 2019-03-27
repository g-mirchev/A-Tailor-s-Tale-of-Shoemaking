using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour
{
	public Text title;
	public Text story;
	public Text stat;
	Ending ending;
	public Animator animator;
	
	public void EndGame(int p)
	{
		animator.SetBool("IsEnd", true);
		FindObjectOfType<MovementLocker>().LockMovement();
		ending = new Ending(p);
		title.text = ending.EndTitle;
		story.text = ending.EndStory;
		stat.text = "Congratulations! You've found ending " + ending.EndNum.ToString() + " of 5";
	}
}
