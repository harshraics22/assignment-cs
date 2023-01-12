using System;

public static class GlobalMembersArray2
{
	//write a program to calculate sum total and average marks of 5 studentin a exam
	 static int Main()
	 {
		 int avg;
		 int sum;
		 int i;
		 int[] marks = new int[5];
	 for (i = 0;i <= 4;i++)
	 {
		 Console.Write("enter marks");
	 string tempVar = ConsoleInput.ScanfRead();
	 if (tempVar != null)
	 {
		 marks[i] = int.Parse(tempVar);
	 }
	 }
	 for (i = 0;i <= 4;i++)
	 {
		 sum = sum + marks[i];
	 }
	 avg = sum / 5;
	 Console.Write("{0:D}\n{1:D}\n",sum,avg);
	 return 0;
	 }
}

