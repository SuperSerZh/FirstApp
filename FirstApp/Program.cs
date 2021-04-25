using System;

class MainClass
{
	public static void Main(string[] args)
	{

		string MyName = "Jane";
		byte MyAge = 27;
		bool HaveIApet = true;
		double MyShoeSize = 37.5;

		Console.WriteLine("My name is " + MyName);
		Console.WriteLine("MyAge " + MyAge);
		Console.WriteLine("Do I have a pet? " + (HaveIApet? "Yes":"No"));
		Console.WriteLine("My shoe size is " + MyShoeSize);

	}
}