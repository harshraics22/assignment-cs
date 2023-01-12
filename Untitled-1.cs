using System;

public static class GlobalMembersUntitledMinus1
{
	static int Main()
	{
		float s1;
		float s2;
		float s3;
		float s4;
		float s5;
		float tm;
		float per;
		Console.Write("enter the marks s1\n");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			s1 = float.Parse(tempVar);
		}
		Console.Write("enter the marks s2\n");
		string tempVar2 = ConsoleInput.ScanfRead();
		if (tempVar2 != null)
		{
			s2 = float.Parse(tempVar2);
		}
		Console.Write("enter the marks s3\n");
		string tempVar3 = ConsoleInput.ScanfRead();
		if (tempVar3 != null)
		{
			s3 = float.Parse(tempVar3);
		}
		Console.Write("enter the marks s4\n");
		string tempVar4 = ConsoleInput.ScanfRead();
		if (tempVar4 != null)
		{
			s4 = float.Parse(tempVar4);
		}
		Console.Write("enter the marks s5\n");
		string tempVar5 = ConsoleInput.ScanfRead();
		if (tempVar5 != null)
		{
			s5 = float.Parse(tempVar5);
		}

		tm = s1 + s2 + s3 + s4 + s5;
		per = tm / 5;
		Console.Write("total marks{0:f}\n",tm);
		Console.Write("total percentage{0:f}",per);
	}
}

