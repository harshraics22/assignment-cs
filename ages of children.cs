using System;

public static class GlobalMembersAgesOfChildren
{
	/*it ages of three children are entered through the keyboard whrite a 
	program to calculate oldest of the three*/ 
	static int Main()
	{
		int c1;
		int c2;
		int c3;
	Console.Write("enter the age of the children");
	string tempVar = ConsoleInput.ScanfRead();
	if (tempVar != null)
	{
		c1 = int.Parse(tempVar);
	}
	string tempVar2 = ConsoleInput.ScanfRead();
	if (tempVar2 != null)
	{
		c2 = int.Parse(tempVar2);
	}
	string tempVar3 = ConsoleInput.ScanfRead();
	if (tempVar3 != null)
	{
		c3 = int.Parse(tempVar3);
	}
	if (c1 > c2 && c1 > c3)
	{
	Console.Write("child 1 is older");
	}
	else
	{
	if (c2 > c1 && c2 > c3)
	{
	Console.Write("child 2 is older");
	}
	else
	{
	if (c3 > c1 && c3 > c2)
	{
	Console.Write("child 3 is older");
	}
	}
	}
	}
}

