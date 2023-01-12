using System;

public static class GlobalMembersSwitch
{
	static int Main()
	{
		sbyte i = (sbyte)'b';

		switch (i)
		{
			case 'a':
		Console.Write("i am in case 1");
		break;
		case 'b':
		Console.Write("i am in case 2");
		break;
		case 'c':
		Console.Write("i am in case 3");
		break;
		default:
		Console.Write("i am in default");
	break;
		}
	}
}

