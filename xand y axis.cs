using System;

public static class GlobalMembersXandYAxis
{
	/* given a point x,y write a program to find out if it lies on x axis 
	or y axis or on the origin*/
	static int Main()
	{
		int x;
		int y;
		Console.Write("enter the coordinate x and y");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			x = int.Parse(tempVar);
		}
		string tempVar2 = ConsoleInput.ScanfRead();
		if (tempVar2 != null)
		{
			y = int.Parse(tempVar2);
		}
		if (x == 0 && y == 0)
		{
		Console.Write("origin");
		}
		else
		{
		if (x != 0 && y == 0)
		{
		Console.Write("on x-axis");
		}
		else if (x == 0 && y != 0)
		{
		Console.Write("on y-axis");
		}
		}

	}
}

