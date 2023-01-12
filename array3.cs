using System;

public static class GlobalMembersArray3
{
	//write a program to find largest element in an array
	static int Main()
	{
		int size;
		int i;
		int largest;
	 Console.Write("enter size of array");
	 string tempVar = ConsoleInput.ScanfRead();
	 if (tempVar != null)
	 {
		 size = int.Parse(tempVar);
	 }
	 int[] array = new int[size];
	 Console.Write("enter %d elements of array");
	 for (i = 0;i < size;i++)
	 {
		 string tempVar2 = ConsoleInput.ScanfRead();
		 if (tempVar2 != null)
		 {
			 array[i] = int.Parse(tempVar2);
		 }
	 }
	 largest = array[0];
	 for (i = 1;i < size;i++)
	 {
		 if (largest < array[i])
		 {
		 largest = array[i];
		 }
	 }
	 Console.Write("largest element is {0:D}",largest);
	 return 0;
	}
}

