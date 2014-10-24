//Author:		    Cale Short
//Program:		  Roll Dice
//Reference:	  xxxxx
//Date:			    Oct 24 2014
//Description:	
//
//Maintenance:	who when why
//

using System;

public class RollDice
{
	public static void Main()
	{
		bool again = true;
		while (again == true)
		{
			Console.Write("How many sides on the dice? >> ");
			int numberOfSides = Convert.ToInt32(Console.ReadLine());
			Console.Write("How many dice to roll? >> ");
			int numberOfDice = Convert.ToInt32(Console.ReadLine());
			
			Roll(numberOfSides, numberOfDice);
			
			Console.WriteLine("Would you like to roll again? Y/N >> ");
			string userAns = Console.ReadLine();
			
			if (userAns == "N" || userAns == "n")
			{
				again = false;
			}
		}
		
		Console.WriteLine("Thanks for rolling");
	}
	public static void Roll(int numSides, int numDice)
	{
		
		Random r = new Random();
		
		for (int i = 0; i < numDice; i++)
		{
			int result = r.Next(1, numSides + 1);
			Console.WriteLine("D{0} = {1}", numSides, result);
		}
	}
}
