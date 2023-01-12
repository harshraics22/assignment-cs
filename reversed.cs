using System;

public static class GlobalMembersReversed
{
	/*write a program to find its reverse of a no. and find out its a
	 palindrome or not*/
	 static int Main()
	 {
		 int n;
		 int r;
		 int sum = 0;
		 int temp;
		 Console.Write("enter the number");
		 string tempVar = ConsoleInput.ScanfRead();
		 if (tempVar != null)
		 {
			 n = int.Parse(tempVar);
		 }
		 temp = n;
		 while (n > 0)
		 {
			 r = n % 10;
		 sum = sum * 10 + r;
		 n = n / 10;
		 }
		 Console.Write("reversed={0:D}\n",sum);

		 if (temp == sum)
		 {
			 Console.Write("palindrome");
		 }
		 else
		 {
			 Console.Write("not a palindrome");
		 }

	 }
}

