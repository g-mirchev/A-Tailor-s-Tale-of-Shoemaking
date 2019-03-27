using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : Interaction
{
    
	public Animator animator;				// reference to the animator
	public Animator doorAnim;
	
	// reference to the input fields
	public InputField ltext;		
	public InputField ctext;		
	public InputField btext;		
	public InputField stext;	
	
	// references to the four text fields that display the numbers on the table variable names should be intuitive
	public Text lPrice;			
	public Text lTotal;
	public Text lAmount;
	public Text cPrice;
	public Text cTotal;
	public Text cAmount;
	public Text bPrice;			
	public Text bTotal;
	public Text bAmount;
	public Text sPrice;
	public Text sTotal;
	public Text sAmount;
	public Text itemN;
	public Text itemD;
	
	
	// Open the shop ny interacting with the door
    public override void Interact()
	{
		doorAnim.SetBool("IsDoorOpen", true);
		FindObjectOfType<StoryManager>().TriggerStoryDoor();
	}
	
	// lock movement and bring out the Shop GUI
	public void OpenShop()
	{
		animator.SetBool("IsShopping", true);
		FindObjectOfType<MovementLocker>().LockMovement();
	}
	
	// unlock movement and dismiss GUI
	public void CloseShop()
	{
		animator.SetBool("IsShopping", false);
		doorAnim.SetBool("IsDoorOpen", false);
		FindObjectOfType<MovementLocker>().UnlockMovement();
		FindObjectOfType<Shop>().tag = "Untagged";
		FindObjectOfType<StoryManager>().AddTradeProgress();
		if(Timeline.Traded)
			Timeline.InteractedT = false;
	}
	
	// the folowing methods are atatched to butons on the GUI and either clear an input field 
	// or put the highest possible value based on the current resources
	public void ClearLeather()
	{
		ltext.text = "0";
	}
	
	public void MaxLeather()
	{
		ltext.text = estimate(Inventory.Leather.Price).ToString();
	}
	
	public void ClearCloth()
	{
		ctext.text = "0";
	}
	
	public void MaxCloth()
	{
		ctext.text = estimate(Inventory.Cloth.Price);
	}
	
		public void ClearBoots()
	{
		btext.text = "0";
	}
	
	public void MaxBoots()
	{
		btext.text = Inventory.Boots.Ammount.ToString();
	}
	
	public void ClearSneakers()
	{
		stext.text = "0";
	}
	
	public void MaxSneakers()
	{
		stext.text = Inventory.Sneakers.Ammount.ToString();
	}
	
	
	// thes next four methods make sure that if the player enters a value too high for to the highest possible
	public void RecalculateL()
	{
		if(ltext.text != "")
		{
			if(int.Parse(ltext.text) > int.Parse(estimate(Inventory.Leather.Price)))
			{
				MaxLeather();
			}
		}
	}
	
	public void RecalculateC()
	{
		if(ctext.text != "")
		{
			if(int.Parse(ctext.text) > int.Parse(estimate(Inventory.Cloth.Price)))
			{
				MaxCloth();
			}
		}
	}
	
	public void RecalculateB()
	{
		if(btext.text != "")
		{
			if(int.Parse(btext.text) > Inventory.Boots.Ammount)
			{
				MaxBoots();
			}
		}
	}
	
	public void RecalculateS()
	{
		if(stext.text != "")
		{
			if(int.Parse(stext.text) > Inventory.Sneakers.Ammount)
			{
				MaxSneakers();
			}
		}
	}
	
	// returns how much of a resource can be purchase wit the current gold
	private string estimate(int a)
	{
		int g = Inventory.Gold;
		if(g <= 0 || a <= 0)
			return "0";
		int m = g % a;
		if(m > 0)
			g -= m;
		return (g/a).ToString();
	}
	
	// The following two methods buy the ammount of recources  stated in the input fields
	// in case the player tries to buy too much for his current gold the ammount will be reduced to the highest possible
	public void BuyL()
	{
		if(ltext.text != "")
		{
			if(Inventory.Gold > 0)
			{
				int a = int.Parse(ltext.text);
				int e = int.Parse(estimate(Inventory.Leather.Price));
				if (a > e)
					a = e;
				Inventory.BuyLeather(a);
				ClearLeather();
			}
		}
	}
	
	public void BuyC()
	{
		
		if(ctext.text != "")
		{
			if(Inventory.Gold > 0)
			{
				int a = int.Parse(ctext.text);
				int e = int.Parse(estimate(Inventory.Cloth.Price));
				if (a > e)
					a = e;
				Inventory.BuyCloth(a);
				ClearCloth();
			}
		}
	}
	
	// these two methods are used to sell what is specified in the sellable fields
	public void SellB()
	{
		
		if(btext.text != "")
		{
			if(Inventory.Boots.Ammount > 0)
			{
				int a = int.Parse(btext.text);
				int e = Inventory.Boots.Ammount;
				if(a > e)
					a = e;
				Inventory.SellBoots(a);
				ClearBoots();
			}
		}
	}
	
	public void SellS()
	{
		
		if(stext.text != "")
		{
			if(Inventory.Sneakers.Ammount > 0)
			{
				int a = int.Parse(stext.text);
				int e = Inventory.Sneakers.Ammount;
				if(a > e)
					a = e;
				Inventory.SellSneakers(a);
				ClearSneakers();
			}
		}
	}
	
	// calculate the total cost of the resource as the player is typing it in the input field
	public void LTotal()
	{
		int t = 0;
		if(ltext.text != "")
			t = int.Parse(ltext.text) * Inventory.Leather.Price;
		lTotal.text = t.ToString() + "g";
	}
	
	public void CTotal()
	{
		int t = 0;
		if(ctext.text != "")
			t = int.Parse(ctext.text) * Inventory.Cloth.Price;
		cTotal.text = t.ToString() + "g";
	}
	
	public void BTotal()
	{
		int t = 0;
		if(btext.text != "")
			t = int.Parse(btext.text) * Inventory.Boots.Price;
		bTotal.text = t.ToString() + "g";
	}
	
	public void STotal()
	{
		int t = 0;
		if(stext.text != "")
			t = int.Parse(stext.text) * Inventory.Sneakers.Price;
		sTotal.text = t.ToString() + "g";
	}
	
	public void InfoLeather()
	{
		itemN.text = Inventory.Leather.Name;
		itemD.text = Inventory.Leather.Describtion;
	}
	
	public void InfoCloth()
	{
		itemN.text = Inventory.Cloth.Name;
		itemD.text = Inventory.Cloth.Describtion;
	}
	
	public void InfoBoots()
	{
		itemN.text = Inventory.Boots.Name;
		itemD.text = Inventory.Boots.Describtion;
	}
	
	public void InfoSneakers()
	{
		itemN.text = Inventory.Sneakers.Name;
		itemD.text = Inventory.Sneakers.Describtion;
	}	
	
	// update the numbers in the shop so they match the correct prices and how much the player owns of each resource
    void Update()
    {
        lPrice.text = Inventory.Leather.Price.ToString() + "g";
		cPrice.text = Inventory.Cloth.Price.ToString() + "g";
		bPrice.text = Inventory.Boots.Price.ToString() + "g";
		sPrice.text = Inventory.Sneakers.Price.ToString() + "g";
		
		lAmount.text = Inventory.Leather.Ammount.ToString();
		cAmount.text = Inventory.Cloth.Ammount.ToString();
		bAmount.text = Inventory.Boots.Ammount.ToString();
		sAmount.text = Inventory.Sneakers.Ammount.ToString();
		
    }
}
