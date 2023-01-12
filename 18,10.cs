using System;

public static class GlobalMembers1810
{
	/*write a program to enter a number less than 10 through the keyboard
	 and print hello c and print hello programming if the no. is greater than 10.*/
	 static int Main()
	 {
		 int num;
		 Console.Write("enter the value");
		 string tempVar = ConsoleInput.ScanfRead();
		 if (tempVar != null)
		 {
			 num = int.Parse(tempVar);
		 }
		 if (num < 10)
		 {
			 Console.Write("Hello world");
		 }
		 else
		 {
			 Console.Write("Hello programming");
		 }
	 }
}

