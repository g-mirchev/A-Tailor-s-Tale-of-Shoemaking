using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
	
	public Animator menuAnim;
	public Text gold;
	public Text day;
	private bool madeProgress;
	public bool MadeProgress
	{
		set {madeProgress = value;}
		get {return madeProgress;}
	}
	private int progress;
	public int Progress
	{
		set {progress = value;}
		get {return progress;}
	}
	
	public void StartStory()
	{
		menuAnim.SetBool("GameStarted", true);
		Progress = 1;
		FindObjectOfType<DialogueManager>().StartDialogue(0, Progress, 1);
	}
	
	public void TriggerStorySleep()
	{
		int i = 0;
		if(!MadeProgress && Progress >= 3 && Timeline.Day != 4)
			i = 14;
		else
		{
			switch (Timeline.Day)
			{
				case 1:
					i = 3;
					break;
				case 2:
					if(MadeProgress && Progress < 5)
						i = 3;
					else
						i = 6;
					break;
				case 3:
					if(MadeProgress && Progress < 5)
						i = 3;
					else if(MadeProgress && Progress < 7)
						i = 6;
					else	
						i = 9;
					break;
				case 4:
					i = 12;
					break;
			}
		}
		FindObjectOfType<DialogueManager>().StartDialogue(i, Progress, 1);
	}
	
	public void TriggerStoryDoor()
	{
		int i = 0;
		if(!MadeProgress && Progress >= 3 && Timeline.Day != 5)
			i = 15;
		else
		{
			switch (Timeline.Day)
			{
				case 1:
					i = 1;
					break;
				case 2:
					i = 5;
					break;
				case 3:
					if(MadeProgress && Progress < 5)
						i = 5;
					else
						i = 8;
					break;
				case 4:
					if(MadeProgress && Progress < 5)
						i = 5;
					else if(MadeProgress && Progress < 7)
						i = 8;
					else
						i = 11;
					break;
				case 5:
					i = 13;
					break;
			}
		}
		FindObjectOfType<DialogueManager>().StartDialogue(i, Progress, 2);
	}
	
	public void TriggerStoryTable()
	{
		int i = 0;
		if(!MadeProgress && Progress >= 3)
			i = 16;
		else
		{
			switch (Timeline.Day)
			{
				case 1:
					i = 2;
					break;
				case 2:
					i = 4;
					break;
				case 3:
					if(MadeProgress && Progress < 5)
						i = 4;
					else
						i = 7;
					break;
				case 4:
					if(MadeProgress && Progress < 5)
						i = 4;
					else if(MadeProgress && Progress < 7)
						i = 7;
					else
						i = 10;
					break;
			}
		}
		FindObjectOfType<DialogueManager>().StartDialogue(i, Progress, 3);
	}
	
	public void TriggerStory(int i)
	{
		FindObjectOfType<DialogueManager>().StartDialogue(i, Progress);
	}
	
	public void AddCraftingProgress()
	{
		if(Timeline.Crafted && Progress % 2 == 0)
		{
			Progress++;
			MadeProgress = true;
		}
		Debug.Log("Progress: " + Progress.ToString());
	}
	
	public void AddTradeProgress()
	{
		if(Timeline.Traded && Progress % 2 != 0)
		{
			Progress++;
			MadeProgress = true;
		}
		Debug.Log("Progress: " + Progress.ToString());
	}
	public void AddProgress(int i)
	{
		//if(Progress >= 9)
		Progress += i;
		Debug.Log("Progress: " + Progress.ToString());
	}
	
	void Update()
	{
		gold.text = "Gold: " + Inventory.Gold.ToString();
		day.text = "Day: " + Timeline.Day.ToString();
	}
}
