using System;
					
public class MyMath
{
	
	public static void Main( string[] args)
	{
		MyMath math = new MyMath();
			Console.WriteLine(math.add(9, 19));
			Console.WriteLine(math.factorial(9));
			Console.WriteLine(math.min(20, 21));
			Console.WriteLine(math.multiply(19, 2)); 
	}
	
	public int add(int a, int b) 
	{
    	return a + b;
	}
	public int factorial(int n)
	{
		int answer = 1;
    	for (int i=2; i<=n; i++)
		{	
			answer *= i;
		}
 		return answer;
	}
	public int multiply(int a, int b)
	{
		return a * b;
	}
	public int min(int a, int b)
	{
		if (a < b)
		{
			return a;
		}
		else
		{
			return b;
		}
	}	
}