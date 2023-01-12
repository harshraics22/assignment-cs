using System;

public static class GlobalMembersNoToBinary
{
	static int Main()
	{
		int[] a = new int[10];
		int number;
		int i;
		int j;
		Console.Write("\n Please Enter the Number You want to Convert  :  ");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			number = int.Parse(tempVar);
		}

		for (i = 0; number > 0; i++)
		{
			a[i] = number % 2;
			number = number / 2;
		}

		Console.Write("\n Binary Number of a Given Number =  ");
		for (j = i - 1; j >= 0; j--)
		{
			Console.Write(" {0:D} ", a[j]);
		}
		Console.Write("\n");
		return 0;
	}
}

