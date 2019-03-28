using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue
{
	private bool clothEnabled = false;
	public bool ClothEnabled
	{
		set{clothEnabled = value;}
		get{return clothEnabled;}
	}
	private bool isEnd = false;
	public bool IsEnd
	{
		set{isEnd = value;}
		get{return isEnd;}
	}
    public string name;
	public string Name
	{
		set {name = value;}
		get {return name;}
	}
	
	public string[] sentences;
	
	
	public Dialogue(int i, int p)
	{
		SetDialogue(i, p);
	}
	
	private void SetDialogue(int i, int p)
	{
		switch (i)
		{
			// Day 1 Dialogue
			case 0:
				Name = "";
				sentences = new string[3];
				sentences[0] = "Once upon a time in a little village on the outskirts of Winchester, there lived an old Shoemaker, alone in his workshop. Every day he would answer the door to the salesman, work on his craft table and sleep in his bed.";
				sentences[1] = " As he was growing older, however, his ability to craft a good shoe was decreasing drastically. Eventuall this led him to a state of Depression. He worked slower and slower, and left the house on fewer and fewer occasions. Most of the villagers had assumed him dead.";
				sentences[2] = "All but Vismund, the village salesman, who came to see the Shoemaker one morning with some rather bad news... Come the dawn, there was a knock on the door";
				break;
			case 1:
				Name = "Vismund";
				sentences = new string[3];
				sentences[0] = "Good morning, 'Old friend'. *Cough* Oh how I regret to inform you that the council tax of 200 gold for your precious little wokshop is due in 5 days. *Wheese* You better start crafting if you don't want to lose it, and I've got just the thing to get you started!";
				sentences[1] = "Only the finest animal hide, from animals grown in a happy and loving *cough* farms, of course. Tell me, Shoemaker, How many pieces of dead cattle does it take to keep a man's feet warm? 5?";
				sentences[2] = "Anyways I don't have too much time to chat, you know the drill, write however much you want to buy *cough* or sell and click the corresponding button. Make your investments wise Shoemaker, I won't be back until tomorrow.";
				break;
			case 2 when p == 1:
				Name = "Shoemaker";
				sentences = new string[1];
				sentences[0] = "My good old crafting table. It's gotten me trough some hard times.";
				break;
			case 2 when p == 2:
				Name = "Shoemaker";
				sentences = new string[1];
				sentences[0] = "I feel way too poorly to work today. Maybe I should leave all the leather on the table. That way when I see it tomoorrow I might get more motivated...";
				break;
			//Day 2 Dialoggue
			case 3 when p < 3:
				Name = "";
				sentences = new string[2];
				sentences[0] = "Having heard the dreadful news the Shoemaker fell in a state of apathy and denial, and went to bed without having done anything to help his case.";
				sentences[1] = "Most times if not all it is very hard to make the first step on one's way out of depression. Come the dawn, there was a knock on the door.";
				break;
			case 3 when p == 3:
				Name = "";
				sentences = new string[3];
				sentences[0] = "Having realised Direness of the situation the Shoemaker fell in a state of panic mixed with bold or rather desperate determination and spent the last of his gold on leather.";
				sentences[1] = "He left the leather on the table and just like that his flaming red determination shifted to a rather gray apathy. He went to bed hoping to find his inspiration in the morning.";
				sentences[2] = "The Shoemaker woke up earlier than the much dreaded knock on the door, and to his surprise found that something peculiar had happened overnight.";
				break;
			case 4 when p < 3:
				Name = "Shoemaker";
				sentences = new string[1];
				sentences[0] = "I don't have enough time for this right now.";
				break;
			case 4 when p == 3:
				Name = "Shoemaker";
				sentences = new string[3];
				sentences[0] = "What?... How?... the boots, they're ready! But I didn't... Oh the quality thought! Such fine detal... I haven't seen a shoe so well crafted since...";
				sentences[1] = "Well... since I used to be able to make them myself. Vismund should be here soon. Ugh, I can't tell him about this he'll think I've lost it for sure this time.";
				sentences[2] = "I hear a knock on the door.";
				break;
			case 4 when p == 4:
				Name = "Shoemaker";
				sentences = new string[1];
				sentences[0] = "I still can't explain what happened last night. Hmm, maybe I should test it again?";
				break;
			case 5 when p < 3:
				Name = "Vismund";
				sentences = new string[1];
				sentences[0] = "What is this? *wheeze* What do you MEAN you crafted nothing?? *cough* Is it more materials that you needed?";
				break;
			case 5 when p == 3:
				Name = "Vismund";
				sentences = new string[2];
				sentences[0] = "HUP, twoo threee four. Ah the exhilarating sound of soldiers marching to serve Queen and Country *cough* as their young maidens wither away.";
				sentences[1] = "What is a man to do but craft the very shoes he once used to walk in. Truely *wheeze* poetic, shoemaker.";
				break;
			// Day 3 Dialogue
			case 6 when p < 3:
				Name = "";
				sentences = new string[3];
				sentences[0] = "Yet another day the Shoemaker spent lying in bed and angrily refusing to do anything to save his career, his home and most of all himself.";
				sentences[1] = "He had dream that night, and in that dream he was stood on the Queen's throne, ordering the execution of Vismund, the councillors and everyone he reckoned responsible for his dire state";
				sentences[2] = "He woke up in sweat midway trough his dream and just lay there for the rest of the night, unable to fall asleep, Come the dawn, there was a knock on the door.";
				break;
			case 6 when p == 5:
				Name = "";
				sentences = new string[2];
				sentences[0] = "Still not being able to comprehend the mysterious crafting of shoes overnight, the Shoemaker left some more leather on the table and went to bed.";
				sentences[1] = "Giving it the benefit of the doubt, however he woke up the next day, quite sooner than the dreaded knock on the door, to check if his beloved table had been up to no good yet again.";
				break;
			case 7 when p == 5:
				Name = "Shoemaker";
				sentences = new string[3];
				sentences[0] = "There it is again! Just like before, I left the leather on the table and the shoes are perfectly crafted. Well almost perfect. Well maybe not that perfect.";
				sentences[1] = "As precise and miniature as the stitches are, there are ever so slightly signs of a rished job. Whoever did this was in a hurry. Never the less this is truily remarkable.";
				sentences[2] = "I hear a knock on the door";
				break;
			case 7 when p == 6:
				Name = "Shoemaker";
				sentences = new string[1];
				sentences[0] = "Third time's the charm I guess. I shouldn't be taking this for granted...";
				break;
			case 8 when p < 3:
				Name = "Vismund";
				sentences = new string[1];
				sentences[0] = "Nothing? Again?? *cough* Quit wasting my time Shoemaker!";
				break;
			case 8 when p == 5:
				Name = "Vismund";
				sentences = new string[2];
				sentences[0] = "Fine, gentle, easy on the eyes... yes your wife truly was an outstanding woman, and a great tailor at that. Working with leather is an impressive craft, sure. But working with cloth... now that's an art.";
				sentences[1] = "Rumor has it that a Chineese is to dock down in Southampton later this afternoon, and that it's bringing textile for the royal wedding. If you're lucky I might just be able to bring you something.";
				break;
			// Day 4 Dialogue;
			case 9 when p < 3:
				Name = "";
				sentences = new string[5];
				sentences[0] = "Once again the Shoemaker made no shoes. Now you're probably wondering why I still bother narrating the dull, uneventful everyday life of some old man. It's because this is not a story about what is seen, but rather what isn't";
				sentences[1] = "The Shoemaker had a dream that night, and in that dream he saw his wife. She was the same as back when he first saw her: young, beautiful and full of life. He saw her sitting on her tailoring table, she was smiling and laughing";
				sentences[2] = "Then, he saw her standing by the door, trying to hide her tears as he was called up for military service. He reached out for her tried to walk back for one final embrace... but as soon as he reached her she was gone.";
				sentences[3] = "He saw her no more, instead he saw the empty house, the cold bed and a tombstone larger than life that read: 'Here lies an abandoned wife and her unborn child'";
				sentences[4] = "And as the tombstone fell forward threatening to crush the Shoemaker, he woke up. Come the dawn, there was a knock on the door";
				break;
			case 9 when p == 7:
				Name = "";
				sentences = new string[2];
				sentences[0] = "And take it for granted he did! He went to bed pondering on who might be entering his house at night and more importantly whether he wanted to interfere with this blessing.";
				sentences[1] = "And ponder he did untill he eventually fell victim to an ever so sweet slumber. Come the dawn, the shoes were on the table and there was a knock on the door";
				break;
			case 10 when p == 8:
				Name = "Shoemaker";
				sentences = new string[1];
				sentences[0] = "One day until I have to pay the councul tax, I hope whoever or whatever is doing this doesn't decide to stop now.";
				break;
			case 11 when p < 3:
				Name = "Vismund";
				sentences = new string[1];
				sentences[0] = "... the royal wedding is tomorrow. I have no time to spend on a sad withered man. Goodbye *wheeze* Shoemaker";
				break;
			case 11 when p == 7:
				ClothEnabled = true;
				Name = "Vismund";
				sentences = new string[2];
				sentences[0] = "Shoemaker! *cough* The royal wedding is tomorrow evening and the Queen's tailor has fallen victim to the plague. They can't have him touch any clothes, yet there are still things to be made.";
				sentences[1] = "I need someone to craft at least 5 pairs of Sneakers for the wedding. Buy the needed cloth and I'll assume you're up for the task. *wheeze* This can be your opportunity to save your workshop!";
				break;
			// Day 5 Dialogue
			case 12 when p < 3:
				IsEnd = true;
				Name = "";
				sentences = new string[5];
				sentences[0] = "'Another day of self neglect, another night of nightmares, is this the life suitable for a heroic man who risked his life to serve both Queen and country? Is this a life worth living?' The shoemaker asked himself that night.";
				sentences[1] = "And he had the answer. Ever since day one he knew the answer yet a man must first go through the four phases of depression before he can even hope to reach acceptance";
				sentences[2] = "And though some might argue that these are the five phases of grief, rather than depression, but I dare ask you what is depression but a constant grief of one's own life?";
				sentences[3] = "The shoemaker had no dreams that night, nor any other night for that matter. And come the dawn there was nothing but the sound of silence";
				sentences[4] = "This concludes the story of the shoemaker, a story played out in real life on a daily basis. Always be on the lookout for what cannot be seen. Signed V. /a friend who wasn't there/";
				break;
			case 12 when p >= 3 && p <= 9:
				IsEnd = true;
				Name = "";
				sentences = new string[2];
				sentences[0] = "The shoemaker went to bed that night and despite the anxiety for the upcoming council tax he managed to fall asleep.";
				sentences[1] = "He had a dream that night and in that dream he saw children playing by the bed of an old deseased man. Come the dawn there was no knock on the door.";
				break;
			case 12 when p == 10:
				IsEnd = true;
				Name  = "";
				sentences = new string[2];
				sentences[0] = "The shoemaker went to bed that night and despite the anxiety for the upcoming council tax he managed to fall asleep.";
				sentences[1] = "He had a dream that night and in that dream he saw children playing by a flayed man. Come the dawn there was a knock on the door.";
				break;
			case 12 when p == 11:
				Name = "";
				sentences = new string[4];
				sentences[0] = "The Shoemaker twisted and turned but he just coulnd't fall asleep. The anxiety for the upcoming trade was overwhelming and so he lay in bed untill he heard his front door open.";
				sentences[1] = "He heard no footsteps enter the house yet he heard a rustling noise from his craft table. He got up to see who was there and to his surprise he saw two children, boy and girl, who had just finished crafting his shoes";
				sentences[2] = "'Who are you children? Why have you been helping me' the shoemaker asked but to no response. The girl made a sign a hand sign signaling they were both deaf and mute.";
				sentences[3] = "As he looked closer he realised they were both barefoot. All these nights of making shoes and not one for themselves. The shoemaker considered giving them two pairs of the shoes they had crafted";
				break;
			case 12 when p == 12:
				Name = "";
				sentences = new string[1];
				sentences[0] = "The children left the shoemaker's house. Soon after the he fell asleep";
				break;
			case 12 when p == 13:
				Name = "";
				sentences = new string[2];
				sentences[0] = "The Shoemaker took two pairs of sneakers from the table and gave them to the children. Their eyes filled with joy as they ran off skipping trough the night. Soon after the he fell asleep";
				sentences[1] = "Come the dawn there was a knock on the door";
				break;
			case 13 when p == 10:
				IsEnd = true;
				Name = "Vismund";
				sentences = new string[1];
				sentences[0] = "What do you mean you didn't craft the shoes?? *wheeze* I trusted you Shoemaker! You've betrayed Queen and country! You'll pay for this!";
				break;
			case 13 when p == 12:
				IsEnd = true;
				Name = "Vismund";
				sentences = new string[1];
				sentences[0] = "Well done, Shoemaker! *cough* You have truily outdone yourself. I will see you again tomorrow!";
				break;
			case 13 when p == 13:
				IsEnd = true;
				Name = "Vismund";
				sentences = new string[2];
				sentences[0] = "What do you mean you have some away... *wheeze* I trusted you sh.. *cough* *cough* Wait it can't be... These Shoes... I saw my children wearing them this morning.";
				sentences[1] = "...Thank you Shoemaker!";
				break;
			// Extra cases for unimportant cases
			case 14:
				Name = "";
				sentences = new string[2];
				sentences[0] = "The Shoemaker decided to take a break today.";
				sentences[1] = "Come the dawn there was a knock on the door";
				break;
			case 15:
				Name = "Vismund";
				sentences = new string[1];
				sentences[0] = "Have you been slacking Shoemaker?";
				break;
			case 16:
				Name = "Shoemaker";
				sentences = new string[1];
				sentences[0] = "Maybe I should do some work.";
				break;
		}
	}
	
}
