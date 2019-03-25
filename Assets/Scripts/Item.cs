using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item		// an abstravt class for the byable and sellible materials in the game
{
	protected int ammount;
	public int Ammount
	{
		set {ammount = value;}
		get {return ammount;}
	}
	protected int price;
	public int Price
	{
		set {price = value;}
		get {return price;}
	}
	
	protected string name;
	protected string Name
	{
		set {name = value;}
		get {return name;}
	}
	
	protected string describtion;
	protected string Describtion
	{
		set {describtion = value;}
		get {return describtion;}
	}
	
	public Item(int a, int p)
	{
		this.ammount = a;
		this.price = p;
	}
	
}
