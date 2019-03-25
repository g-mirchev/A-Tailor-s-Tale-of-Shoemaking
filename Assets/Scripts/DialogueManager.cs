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
	
	public MovementLocker movementLocker;
	
    // Create a que of strings to feed in the dialog box
    void Start()
    {
        sentences = new Queue<string>();
    }
	
	// lock player movement and bring up the dialog box entering the name of the NPC speaking and their speech
	public void StartDialogue(Dialogue dialogue)
	{
		movementLocker.lockMovement();
		
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
		movementLocker.unlockMovement();
		animator.SetBool("IsOpen", false);
	}
	
}
