using System;

public static class GlobalMembersArmstrongNo
{
	/*write a program to print out all armstrong b/w 1 and 1000 */
	static int Main()
	{
		int n;
		int a;
		int b;
		int c;
		int temp;
	Console.Write("enter the armstrong");
	string tempVar = ConsoleInput.ScanfRead();
	if (tempVar != null)
	{
		n = int.Parse(tempVar);
	}
	while (n <= 1000)
	{
	a = n % 10;
	b = n % 100;
	b = (b - a) / 10;
	c = n / 100;
	if ((a * a * a + b * b * b + c * c * c) == n)
	{
		Console.Write("ARMSTRONG");
		break;
	}
	else
	{
		Console.Write("not a armstrong");
		break;
	}
	}
	}
}

