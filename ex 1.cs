using System;

public static class GlobalMembersEx1
{
	static int Main()
	{
	   int c = 0;
	   int d = 15;
	   int e = 100;
	   int a;
	   int b;
	   a = c > 1?d > 1 || e > 1?10:20:30;
	   b = c != 1?d > 1 || e > 1?10:20:30;
	   Console.Write("a={0:D}, b={1:D}",a,b);
		return 0;
	}
}

