using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleep : Interaction
{
	
	public override void Interact()
	{
		FindObjectOfType<ChoiceManager>().StartChoice(this.gameObject, "Sleep?", "Yes Zzz...", "Not Yet");
	}
	
	public override void Consequence(string c)
	{
		switch (c)
		{
			case "A":
				Debug.Log("Ok sleeping now ZZZZZZZZZZZ");
				break;
			case "B":
				Debug.Log("No sleep yet");
				break;
		}
	}
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		
    }
}
