using System;

public static class GlobalMembersAreaOfTriangle
{
	static int Main()
	{
		float a;
		float b;
		float c;
		float s;
		float area;
	Console.Write("\nEnter the side ");
	string tempVar = ConsoleInput.ScanfRead();
	if (tempVar != null)
	{
		a = float.Parse(tempVar);
	}
	string tempVar2 = ConsoleInput.ScanfRead();
	if (tempVar2 != null)
	{
		b = float.Parse(tempVar2);
	}
	string tempVar3 = ConsoleInput.ScanfRead();
	if (tempVar3 != null)
	{
		c = float.Parse(tempVar3);
	}
	s = (a + b + c) / 2;
	area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
	Console.Write("area of triangle={0:f}\n",area);
	}
}

