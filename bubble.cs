using System;

public static class GlobalMembersBubble
{
	static int Main()
	{
		int[] a = new int[100];
		int number;
		int i;
		int j;
		int temp;
	Console.Write("\n enter total no. of element");
	string tempVar = ConsoleInput.ScanfRead();
	if (tempVar != null)
	{
		number = int.Parse(tempVar);
	}
	Console.Write("\n enter array element ");
	for (i = 0;i < number;i++)
	{
	string tempVar2 = ConsoleInput.ScanfRead();
	}
	if (tempVar2 != null)
	{
		a[i] = int.Parse(tempVar2);
	}
	for (i = 0;i < number - 1;i++)
	{
	for (j = 0;j < number - i - 1;j++)
	{
	if (a[j] > a[j + 1])
	{
	temp = a[j];
	}
	}
	}
	a[j] = a[j + 1];
	a[j + 1] = temp;
	Console.Write("array in ascending order\n");
	for (i = 0;i < number;i++)
	{
	Console.Write("{0:D}\t",a[i]);
	}
	Console.Write("\n");

	}
}

