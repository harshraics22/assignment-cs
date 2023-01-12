using System;

public static class GlobalMembersPattern
{
	static int Main()
	{
		int i;
		int j;
		int rows;
	Console.Write("enter the number of rows");
	string tempVar = ConsoleInput.ScanfRead();
	if (tempVar != null)
	{
		rows = int.Parse(tempVar);
	}

	for (i = 1;i <= rows;i++)
	{
		for (j = 1;j <= i;j++)
		{
		Console.Write("*");
		}
	Console.Write("\n");
	}
	return 0;
	}
}

