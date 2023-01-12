using System;

public static class GlobalMembers18103
{
	static int Main()
	{
		int a = 19;
		int b;
		int c;
		int d;
		int e;
		int f;
		int g;
		int u;
	b = a++;
	c = a != 0 && b != 0;
	d = a != 0 || b != 0;
	e = a ^ b;
	f = a | b;
	g = ++f;
	u %= a;
	g += d;

	Console.Write("{0:D}\n",b);
	Console.Write("{0:D}\n",c);
	Console.Write("{0:D}\n",d);
	Console.Write("{0:D}\n",e);
	Console.Write("{0:D}\n",f);
	Console.Write("{0:D}\n",g);
	Console.Write("{0:D}\n",u);
	Console.Write("{0:D}\n",g);


	}
}

