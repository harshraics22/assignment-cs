using System;

public static class GlobalMembersArmstrongAllNo
{
	static int Main()
	{
		int i = 1;
		int a;
		int b;
		int c;
		Console.Write("armstrong number\n");
		while (i < 1000)
		{
			a = i % 10;
		b = i % 100;
		b = (b - a) / 10;
		c = i / 100;
		if (a * a * a + b * b * b + c * c * c == i)
		{
			Console.Write("{0:D}\n",i);
		}
		i++;
		}
	}
}

