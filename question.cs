using System;

public static class GlobalMembersQuestion
{
	/*write a program to print fibomacci numbers upto a given term*/
	//write  a program to print multiplication table of a number entered by the user
	//table must be in formed 7*1=7,7*2=14,7*3=21----7*10=70
	static int Main()
	{
		int t1 = 0;
		int t2 = 1;
		int nt = 0;
		int n;
	Console.Write("enter a positive number");
	string tempVar = ConsoleInput.ScanfRead();
	if (tempVar != null)
	{
		n = int.Parse(tempVar);
	}
	while (nt <= n)
	{
		Console.Write("{0:D}\n",nt);
	t1 = t2;
	t2 = nt;
	nt = t1 + t2;
	}
	return 0;
	}
}

