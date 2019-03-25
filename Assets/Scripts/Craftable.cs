using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Craftable : Item
{
    protected int consumption;		// a craftable item has this variable that shows how much material is needed to craft the item
	public int Consumption
	{
		set {consumption = value;}
		get {return consumption;}
	}
	
	public Craftable(int a, int p, int c) : base(a, p)
	{
		this.consumption = c;
	}
	
}
