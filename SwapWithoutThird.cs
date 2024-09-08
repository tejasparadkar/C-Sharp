using System;
class SwapWithoutThird
{
	static int a,b;
	public static void getInput()
	{
		Console.WriteLine("Enter number1: ");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter number2: ");
		b=Convert.ToInt32(Console.ReadLine());
		
	}
	public static void swap()
	{
		a=a+b;
		b=a-b;
		a=a-b;
		Console.WriteLine("After swap num1: {0} and num2: {1}",a,b);
	}
	public static void Main()
	{
		//SwapWithoutThird s = new SwapWithoutThird();
		getInput();
		swap();
	}
}