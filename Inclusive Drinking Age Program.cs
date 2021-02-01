
using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Please enter your height in cm.");

		//user inputs height
		//user's input is stored in string variable 'userHeight'

		string userHeight = Console.ReadLine();

		//userHeight is converted to float

		float height;
		height = float.Parse(userHeight);

		//Checking that the user's height meets the requirments

		if(height >= 120 )
        {
			Console.WriteLine("You are tall enough to ride the rollercoaster");
        }
        else
        {
			Console.WriteLine("Sorry, you are not tall enough to ride the rollercoaster");
		}

		

	}
}