using System;
class Pallindrome
{
	public static void Main()
	{
		Console.Write("Enter a number: ");
		int num=Convert.ToInt32(Console.ReadLine());
		int rev=0;
		int temp=num;
		while(num!=0)
		{
			int d=num%10;
			rev=(rev*10)+d;
			num=num/10;
		}
		if(rev==temp)
		{
			Console.WriteLine("Pallindrome");
		}
		else
		{
			Console.WriteLine("Not Pallindrome");
		}
	}
}