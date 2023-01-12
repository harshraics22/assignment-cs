using System;

public static class GlobalMembersAPlusPlus
{
	static int Main()
	{
		int a = 10;
		int b;
		int c;
		int d;
		int e;
		a = a++;
		b = ++a;
		c = b++;
		d = ++b;
		e = c++;

		Console.Write("{0:D} {1:D} {2:D} {3:D} {4:D}",a,b,c,d,e);
		return 0;
	}
}

