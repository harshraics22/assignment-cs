using System;

public static class GlobalMembersH
{
	static int Main()
	{
		int a;
		int b;
		int sum;
		int sub;
		int mul;
		int div;
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
		Console.Write("{0:D}\n",sum);
	Console.Write("{0:D}\n",sub);
	Console.Write("{0:D}\n",mul);
	Console.Write("{0:D}\n",div);
	}
}

