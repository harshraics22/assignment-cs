using System;

public static class GlobalMembersUseOfPointer
{
	//write a program to study a use of pointer in c programing
	static int Main()
	{
		int i = 3;
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: int *j;
		int j;
		int[][] k;
	j = i;
	k = &j;
	Console.Write("\n Address of i={0:D}", i);
	Console.Write("\n Address of i={0:D}", j);
	Console.Write("\n Address of i={0:D}", k);
	Console.Write("\n Address of j={0:D}", j);
	Console.Write("\n Address of j={0:D}",k);
	Console.Write("\n Address of k={0:D}", k);
	Console.Write("\n value of j={0:D}",j);
	Console.Write("\n value of k={0:D}",k);
	Console.Write("\n value of i={0:D}",i);
	Console.Write("\n value of i={0:D}", *(i));
	Console.Write("\n value of i={0:D}", j);
	Console.Write("\n value of i={0:D}",* k);
	}
}

