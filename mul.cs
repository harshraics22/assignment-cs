using System;

public static class GlobalMembersMul
{
	static int Main()
	{
		int a;
		int b;
		int sum = 0;
		int sub = 0;
		int mul = 0;
		int div = 0;
		Console.Write("enter the value a and b");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			a = int.Parse(tempVar);
		}
		string tempVar2 = ConsoleInput.ScanfRead();
		if (tempVar2 != null)
		{
			b = int.Parse(tempVar2);
		}
		sum = a + b;
		sub = a - b;
		mul = a * b;
		div = a / b;
		Console.Write("{0:D}",sum);
	Console.Write("{0:D}",sub);
	Console.Write("{0:D}",mul);
	Console.Write("{0:D}",div);
	}
}

