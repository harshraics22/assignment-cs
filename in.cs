using System;

public static class GlobalMembersIn
{
	static int Main()
	{
		int a;
		int b;
		Console.Write("enter a here :");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			a = int.Parse(tempVar);
		}
		Console.Write("enter b here :");
		string tempVar2 = ConsoleInput.ScanfRead();
		if (tempVar2 != null)
		{
			b = int.Parse(tempVar2);
		}
		Console.Write("the larger number is {0:D}",a > b != 0?a:b);
	}
}

