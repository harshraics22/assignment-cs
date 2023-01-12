using System;

public static class GlobalMembersReversedTriangle
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
		Console.Write("{0:D}",j);
		}
	Console.Write("\n");
	}
	return 0;
	}
}

