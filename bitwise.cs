using System;

public static class GlobalMembersBitwise
{
	static int Main()
	{
		int a = 12;
		int b = 21;
		Console.Write("\n and {0:D}", a != 0 && b != 0);
		Console.Write("\n or {0:D}",a != 0 || b != 0);
		Console.Write("\n not {0:D}",a | b);
		Console.Write("\n xor{0:D}",a ^ b);
	}
}

