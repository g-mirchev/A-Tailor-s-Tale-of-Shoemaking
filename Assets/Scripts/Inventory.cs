using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Inventory				// Store all the inventory information
{
	
	public static int gold;					// Main resource used to buy materials
	public static int Gold					// aquired by selling shoes
	{
		set {gold = value;}
		get {return gold;}
	}
	
	// Refferences to the two materials so far
	public static Item cloth;
	public static Item Cloth
	{
		get {return cloth;}
	}
	public static Item leather;
	public static Item Leather
	{
		get {return leather;}
	}
	
	// reference to the two craftable items so far
	public static Craftable boots;
	public static Craftable Boots
	{
		get {return boots;}
	}
	public static Craftable sneakers;
	public static Craftable Sneakers
	{
		get {return sneakers;}
	}
	
	// the materials ledt on the crafting table input fields get stored here so the Elves can do their magic
	public static int leatherToUse;
	public static int LeatherToUse
	{
		set {leatherToUse = value;}
		get {return leatherToUse;}
	}
	public static int clothToUse;
	public static int ClothToUse
	{
		set {clothToUse = value;}
		get {return clothToUse;}
	}
	
	// Constructing the inventory giving the initial resources for the game
	static Inventory()
   {
		Reset();
   }
   
   public static void Reset()
   {
	   gold = 10;
	   cloth = new Cloths(0, 5);
	   leather = new Leather(0, 2);
	   boots = new Boots(0, 20, 5);
	   sneakers = new Sneakers(0, 40, 3);
	   leatherToUse = 0;
	   clothToUse = 0;
   }
   
	// the following two methods convert gold into materials using some simple economic alchemy
	public static void BuyCloth(int ammount)
	{
		if (ammount <= 0 || gold < cloth.Price*ammount)
			return;
		gold -= cloth.Price*ammount;
		cloth.Ammount += ammount;
		Timeline.Traded = true;
	}
	
	public static void BuyLeather(int ammount)
	{
		if (ammount <= 0 || gold < leather.Price*ammount)
			return;
		gold -= leather.Price*ammount;
		leather.Ammount += ammount;
		Timeline.Traded = true;
	}
	
	// the above processes but modified to convert shoes into gold
	public static void SellBoots(int a)
	{
		if(boots.Ammount == 0)
			return;
		gold += boots.Price*a;
		boots.Ammount -= a;
	}
	
	public static void SellSneakers(int a)
	{
		if(sneakers.Ammount == 0)
			return;
		gold += sneakers.Price*a;
		sneakers.Ammount -= a;
	}
	
	// this may or may not have an impact on the story #nospoilers
	public static void DonateSneakers()
	{
		sneakers.Ammount -= 2;
		Timeline.Donated = true;
	}
	
	// The following two methods are sacred Elven magic. Please look away now!
	public static void CraftBoots()
	{
		if(leatherToUse <= 0 || leatherToUse < boots.Consumption)
			return;
		if(leatherToUse%boots.Consumption > 0)
			leatherToUse -= leatherToUse%boots.Consumption;
		boots.Ammount += leatherToUse/boots.Consumption;
		leather.Ammount -= leatherToUse;
		Timeline.Crafted = true;
	}
	
	public static void CraftSneakers()
	{
		if(clothToUse <= 0 || clothToUse < sneakers.Consumption)
			return;
		if(clothToUse%sneakers.Consumption > 0)
			clothToUse -= clothToUse%sneakers.Consumption;
		sneakers.Ammount += clothToUse/sneakers.Consumption;
		cloth.Ammount -= clothToUse;
		Timeline.Crafted = true;
	}
   
}
