using System;

public static class GlobalMembersBinaryToDec
{
	//write a program to convert binary into decimal 
	public static int convert(long n)
	{
	int dec = 0;
	int i = 0;
	int rem;
	while (n != 0)
	{
	rem = n % 10;
	n = n / 10;
	dec = dec + Math.Pow(2,i) * rem;
	++i;
	}
	 return dec;
	}
	static int Main()
	{
		long n;
		Console.Write("enter binary no");
		Console.Write("{0:D} in binary = {1:D} in decimal",n,convert(n));
		return 0;
	}
}

