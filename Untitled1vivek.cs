using System;

public static class GlobalMembersUntitled1vivek
{
	static int Main()
	{
		int a;
		int b;
		int c;
		Console.Write("enter two value");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			a = int.Parse(tempVar);
		}
		string tempVar2 = ConsoleInput.ScanfRead(",");
		if (tempVar2 != null)
		{
			b = int.Parse(tempVar2);
		}
		c = a + b;
		Console.Write("the value{0:D}", c);
	}
}

