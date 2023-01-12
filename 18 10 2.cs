using System;

public static class GlobalMembers18102
{
	/* while purchasing certain items a discount of 10 % is offered if the quantity purchased is more than 1000
	if quantity and price are enter through the keyboard write a program to calculate total expencive*/
	static int Main()
	{

		float qty;
		float dis;
		float pr;
		float tot;
		Console.Write("enter quantity and price");
		string tempVar = ConsoleInput.ScanfRead();
		if (tempVar != null)
		{
			qty = float.Parse(tempVar);
		}
		string tempVar2 = ConsoleInput.ScanfRead();
		if (tempVar2 != null)
		{
			pr = float.Parse(tempVar2);
		}
		if (qty > 1000)
		{
			dis = 10F;
		}
		tot = pr * qty - (pr * qty * dis) / 100;
		Console.Write("{0:f}",tot);
	}
}

