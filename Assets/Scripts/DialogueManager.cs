using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour  // I learned how to make this from this video https://www.youtube.com/watch?v=_nRzoTzeyxU
{
	public Text nameText;
	public Text dialogueText;
	
	public Animator animator;
	
	private Queue<string> sentences;
	public GameObject clothPanelShop;
	public GameObject clothPanelTable;
	
	private int afterClose = 0;
	private int prog = 1;
	Dialogue dialogue;
	
    // Create a que of strings to feed in the dialog box
    void Start()
    {
        sentences = new Queue<string>();
    }
	
	// lock player movement and bring up the dialog box entering the name of the NPC speaking and their speech
	public void StartDialogue(int i, int p, int a = 0)
	{
		prog = p;
		afterClose = a;
		Timeline.InDialogue = true;
		
		dialogue = new Dialogue(i, p);
	
		FindObjectOfType<MovementLocker>().LockMovement();
		
		animator.SetBool("IsOpen", true);
		
		nameText.text = dialogue.name;
		
		sentences.Clear();									// clear the box of any previous dialog
		
		foreach(string sentence in dialogue.sentences)		// add sentences in the queue
		{
			sentences.Enqueue(sentence);
		}
		
		DisplayNextSentence();
	}
	
	// this is bound to the continue button, dequeue sentences from tue queue and send them to the dialog box
	public void DisplayNextSentence()
	{
		if(sentences.Count == 0)
		{
			EndDialouge();
			return;
		}
		
		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}
	
	// This makes the sentence come out character by character giving it a smoother trasnition
	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach(char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}
	
	// close the dialog box when done
	void EndDialouge()
	{
		animator.SetBool("IsOpen", false);
		Timeline.InDialogue = false;
		
		switch (afterClose)
		{
			case 0:
				FindObjectOfType<MovementLocker>().UnlockMovement();
				break;
			case 1:
				FindObjectOfType<Sleep>().WakeUp();
				break;
			case 2:
				if(dialogue.ClothEnabled)
				{
					clothPanelShop.SetActive(true);
					clothPanelTable.SetActive(true);
				}
				FindObjectOfType<Shop>().OpenShop();
				break;
			case 3:
				FindObjectOfType<ShoeTable>().OpenWorkingTable();
				break;
		}
		if(dialogue.IsEnd)
			FindObjectOfType<EndingManager>().EndGame(prog);
	}
	
}
