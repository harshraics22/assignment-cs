using System;

public static class GlobalMembersTriangle
{
	/*write a program to check wheather triangle is valid or not when three 
	angle of the triangle are entered through the keyboard */
	static int Main()
	{
		int a;
		int b;
		int c;
		int tri;
		Console.Write("enter the angle a,b,c");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			a = int.Parse(tempVar);
		}
		string tempVar2 = ConsoleInput.ScanfRead();
		if (tempVar2 != null)
		{
			b = int.Parse(tempVar2);
		}
		string tempVar3 = ConsoleInput.ScanfRead();
		if (tempVar3 != null)
		{
			c = int.Parse(tempVar3);
		}
		tri = a + b + c;
		if (tri == 180)
		{
		Console.Write("triangle is valid");
		}
		else
		{
		Console.Write("triangle is not valid");
		}
	}
}

