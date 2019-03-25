using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Timeline
{
	
	public static int day;
	public static int Day
	{
		set {day = value;}
		get {return day;}
	}
   
   static Timeline()
   {
	   day = 8;
   }
   
   public static void NextDay()
   {
	   day--;
   }
   
}
