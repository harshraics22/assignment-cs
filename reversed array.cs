using System;

public static class GlobalMembersReversedArray
{
	//write a program to read value in an array and display it in reverse order
	static int Main()
	{
		int i;
		int n;
		int[] a = new int[100];
	Console.Write("input the element ");
	string tempVar = ConsoleInput.ScanfRead();
	if (tempVar != null)
	{
		n = int.Parse(tempVar);
	}
	Console.Write("input the element in array");
	for (i = 0;i < n;i++)
	{
		Console.Write("\nelement:{0:D}=",i);
	string tempVar2 = ConsoleInput.ScanfRead();
	if (tempVar2 != null)
	{
		a[i] = int.Parse(tempVar2);
	}
	}
	Console.Write("the value stored in the array in reverse order = ");
	for (i = n - 1;i >= 0;i--)
	{
		Console.Write("{0:D}",a[i]);
	}
	Console.Write("\n");
	return 0;
	}
}

