//Author:		Cale Short
//Program:		Roll Dice
//Reference:		xxxxx
//Date:			Oct 24 2014
//Description:		
//
//Maintenance:		who when why
//

using System;

public class RollDice
{
	public static void Main()
	{
		bool again = true, check = false;
		int numberOfSides, numberOfDice;
		string inString, userAns;
		while (again == true)
		{
			// Get user values
			do
			{
				check = false;
				Console.Write("How many sides on the dice? >> ");
				inString = Console.ReadLine();
				numberOfSides = GetIntValue(inString);
				if (numberOfSides > 0)
					check = true;
				else
					check = false;
			}
			while (check == false);
			do
			{
				check = false;
				Console.Write("How many dice to roll? >> ");
				inString = Console.ReadLine();
				numberOfDice = GetIntValue(inString);
				if (numberOfDice > 0)
					check = true;
				else
					check = false;
			}
			while (check == false);	
			
			// Roll the dice
			Roll(numberOfSides, numberOfDice);
			
			// Run it again?
			do
			{
				check=false;
				Console.WriteLine("Would you like to play again? Y/N >> ");
				userAns = Console.ReadLine();
				userAns = userAns.ToUpper();
				if (userAns =="Y" || userAns =="YES")
				{
					again = true;
					check = true;
				}
				else if (userAns == "N" || userAns =="NO")
				{
					again = false;
					check = true;
				}
				else check = false;
			}
			while (check == false);
		}
		
		// Exit confirmation
		Console.WriteLine("Thanks for rolling!");
	}
	
	// Dice rolling method
	public static void Roll(int numSides, int numDice)
	{
		Random r = new Random();
		for (int i = 0; i < numDice; i++)
		{
			int result = r.Next(1, numSides + 1);
			Console.WriteLine("D{0} = {1}", numSides, result);
		}
	}
	
	// Convert string to int method using TryParse
	public static int GetIntValue(string str)
	{
		int result;
		int.TryParse(str, out result);
		// return a -1 if string is not an int
		return result;
	}
}
