using System;

public static class GlobalMembersArrayPlusveMinusve0
{
	//write a program to input a array of 10 numbers and count total no of positive , negative and zero 
	//elements and display there count
	static int Main()
	{
		int[] a = new int[DefineConstants.N];
		int i;
		int p = 0;
		int n = 0;
		int z = 0;
	Console.Write("enter the element ");
	for (i = 0;i < DefineConstants.N;i++)
	{
	string tempVar = ConsoleInput.ScanfRead();
	}
	if (tempVar != null)
	{
		a[i] = int.Parse(tempVar);
	}
	for (i = 0;i < DefineConstants.N;i++)
	{
	if (a[i] > 0)
	{
	p++;
	}
	else if (a[i] < 0)
	{
	n++;
	}
	else
	{
	z++;
	}
	}
	Console.Write("\npositive number= {0:D}",p);
	Console.Write("\nnegative number= {0:D}",n);
	Console.Write("\nzero elements= {0:D}",z);
	return 0;

	}
}

