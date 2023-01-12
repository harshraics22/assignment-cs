using System;

public static class GlobalMembersMatrixAddition
{
	//adding of matrix 
	 static int Main()
	 {
		 int m;
		 int n;
	 Console.Write("enter order of matrix");
	 string tempVar = ConsoleInput.ScanfRead();
	 if (tempVar != null)
	 {
		 m = int.Parse(tempVar);
	 }
	 string tempVar2 = ConsoleInput.ScanfRead();
	 if (tempVar2 != null)
	 {
		 n = int.Parse(tempVar2);
	 }
	 int i;
	 int j;
	 int[,] mat1 = new int[m, n];
	 int[,] mat2 = new int[m, n];
	 int[,] mat3 = new int[m, n];
	 for (i = 0;i < m;i++)
	 {
		 for (j = 0;j < n;j++)
		 {
		 string tempVar3 = ConsoleInput.ScanfRead();
		 if (tempVar3 != null)
		 {
			 mat1[i, j] = int.Parse(tempVar3);
		 }
		 }
	 }
	 for (i = 0;i < m;i++)
	 {
		 for (j = 0;j < n;j++)
		 {
		 string tempVar4 = ConsoleInput.ScanfRead();
		 if (tempVar4 != null)
		 {
			 mat2[i, j] = int.Parse(tempVar4);
		 }
		 }
	 }
	 for (i = 0;i < m;i++)
	 {
		 for (j = 0;j < n;j++)
		 {
		 mat3 [i, j] = mat1[i, j] + mat2[i, j];
		 }
	 }
	 for (i = 0;i < m;i++)
	 {
		 for (j = 0;j < n;)
		 {
		 Console.Write("{0:D}",mat3[i, j]);
	 Console.Write("\n");
		 }
	 }
	 }
}

