using System;

public static class GlobalMembersCircleCoordinate
{
	/*given the coordinate x and y of a centre of a circle and its radius write a 
	program which will determine wheather a point lies inside the circle on
	 the circle and outside the circle*/
	 static int Main()
	 {
		 int x;
		 int y;
		 int r;
		 int dis;
		 int d;
		 Console.Write("enter the value of x,y and r");
		 string tempVar = ConsoleInput.ScanfRead();
		 if (tempVar != null)
		 {
			 x = int.Parse(tempVar);
		 }
		 string tempVar2 = ConsoleInput.ScanfRead();
		 if (tempVar2 != null)
		 {
			 y = int.Parse(tempVar2);
		 }
		 string tempVar3 = ConsoleInput.ScanfRead();
		 if (tempVar3 != null)
		 {
			 r = int.Parse(tempVar3);
		 }
		 dis = x * x + y * y;
		 d = r * r;
		if (dis > d)
		{
		Console.Write("outside the circle");
		}
		else
		{
		if (dis < d || dis == d)
		{
		Console.Write("inside the circle");
		}
		}
	 }
}

