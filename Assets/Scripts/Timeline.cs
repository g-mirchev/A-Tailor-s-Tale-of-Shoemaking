using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Timeline
{
	public static bool interactedT;
	public static bool InteractedT
	{
		set {interactedT = value;}
		get {return interactedT;}
	}
	public static bool traded;
	public static bool Traded
	{
		set {traded = value;}
		get {return traded;}
	}
	public static bool crafted;
	public static bool Crafted
	{
		set {crafted = value;}
		get {return crafted;}
	}
	public static bool donated;
	public static bool Donated
	{
		set {donated = value;}
		get {return donated;}
	}
	public static bool playerAsleep;
	public static bool PlayerAsleep
	{
		set {playerAsleep = value;}
		get {return playerAsleep;}
	}
	
	public static bool inDialogue;
	public static bool InDialogue
	{
		set {inDialogue = value;}
		get {return inDialogue;}
	}
	
	public static int day;
	public static int Day
	{
		set {day = value;}
		get {return day;}
	}
   
	static Timeline()
	{
		day = 0;
		Traded = false;
		Crafted = false;
		Donated = false;
		InteractedT = false;
	}
   
	public static void NextDay()
	{
		Traded = false;
		Crafted = false;
		day++;
	}
	
}
