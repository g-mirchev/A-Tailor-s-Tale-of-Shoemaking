﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
   
   public Dialogue dialogue;
   
   
   // start a new dialogue 
   public void TriggerDialogue()
   {
	   FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
   }
   
}
