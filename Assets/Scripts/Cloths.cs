using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloths : Item		// I had to name this Cloths because CLoth clashed with a built in Unity script... CLOTHS >_< 
{
	public Cloths(int a, int p) : base(a, p) 
	{
		Name = "Cloth";
		Describtion = "Fine, gentle, easy on the eyes... yes your wife truly was an outstanding woman, and a great tailor at that. I am so sorry for your loss Shoemaker.";
	}
}
