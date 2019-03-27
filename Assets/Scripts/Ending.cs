using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending
{
	
	private string endTitle;
	public string EndTitle
	{
		set{endTitle = value;}
		get{return endTitle;}
	}
	private string endStory;
	public string EndStory
	{
		set{endStory = value;}
		get{return endStory;}
	}
	private int endNum;
	public int EndNum
	{
		set{endNum = value;}
		get{return endNum;}
	}

	public Ending(int p)
	{
		SetEnding(p);
	}

	public void SetEnding(int p)
	{
		switch (p)
		{
			case 1:
			case 2:
				EndNum = 1;
				EndTitle = "The Friend Who Wasn't There";
				EndStory = "After losing his wife and unborn child while on military service, the Shoemaker fell into a severe depression to the point where he wouldn't care about himself nor his workshop. /n He ended up commiting suicide during the Royal Wedding. Witnesses say they found him lying dead with a smile on his face. /n His former best friend Vismund, who couldn't bare the guilt of abandoning the Shoemaker in his moments of need, followed his example about a week later.";
				break;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
				EndNum = 2;
				EndTitle = "Well You Tried... Now What?";
				EndStory = "After working a few days and taking a few days off the Shoemaker eventually failed to gather the money for his council tax and was thus kicked out by the council. /n Some people state that they have seen the old man  scavaging the streets, making footware from dead rodent hides and attempting to sell them. Others believe he is now dead. /n Vismund was found dead from tuberculosis one night after coughing and wheezing in agony for what seemend like ages.";
				break;
			case 10:
				EndNum = 3;
				EndTitle = "National Traitor";
				EndStory = "After personally making a sacred oath to Her Majesty The Queen, the local Shoemaker proceeded to go back on his word and malliciosly sabotaged the Royal Wedding. /n Her Majesty and the entire Royal Family are still in shock from this vial demonstration of terrorism. /n His accomplice Vismund was also procecuted and despite pleading guilty, both men were publicly flayed and executed. Their corpses are to stay in front of Winchester Cathedras for the next fornight as a symbol of peace";
				break;
			case 12:
				EndNum = 4;
				EndTitle = "Artician Shoemaker";
				EndStory = "After countless nights of hard work almost no sleep, the Shoemaker managed to pay his council tax and even had enough money left over to start his own trademark 'The Shoemaker's Eves'. /n Several charges have been placed on the company for using child labor, however all were dismissed due to the lack of substantial evidence. /n Local salesman Vismund was the main issuer of these charges, until he went missing for a few weeks. His body was recently discovered burried near an old worksop like house on the outskirts of Winchester";
				break;
			case 13:
				EndNum = 5;
				EndTitle = "A Kind Old Bloke";
				EndStory = "The Shoemaker failed to get enough money for the council tax and ended up losing the workshop. He was however promoted by vismund to become a trainer in the local tailoring accademy. /n He spent the rest of his days teaching young tailors the tricks of the trait. Vismund's children were one of his first and best desciples. /n They managed to start a business of their own and were finally able to afford a cure for their father's tuberculosis";
				break;
		}
	}

}
