using System;

public static class GlobalMembersUntitled1
{
	static int Main()
	{
		int two_th;
		int five_h;
		int two_h;
		int one_h;
		int amnt;
		Console.Write("enter the value:-");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			amnt = int.Parse(tempVar);
		}
		amnt = amnt - 100;
		two_th = amnt / 2000;
		amnt = amnt % 2000;
		five_h = amnt / 500;
		amnt = amnt % 500;
		two_h = amnt / 200;
		amnt = amnt % 200;
		one_h = amnt / 100;
		Console.Write("the number of notes required to fullfill the amount is as follow:\n");
		Console.Write("{0:D} 2000 notes\n",two_th);
		Console.Write("{0:D} 500 notes\n",five_h);
		Console.Write("{0:D} 200 notes\n",two_h);
		Console.Write("{0:D} 100 notes\n",one_h + 1);
	}
}

