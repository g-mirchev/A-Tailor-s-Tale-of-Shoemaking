using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloths : Item		// I had to name this Cloths because CLoth clashed with a built in Unity script... CLOTHS >_< 
{
	public Cloths(int a, int p) : base(a, p) 
	{
		Name = "Cloth";
		Describtion = "A woven fabric made of wool. Makes for a comfy, warm and stylish shoe.";
	}
}
