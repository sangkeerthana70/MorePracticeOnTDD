 using System;
using System.Text;
					
public class Program
{
	public static void Main()
	{
		string str = "the-bicycle-thief";
		string result = ToCamelCase(str);
		//Console.WriteLine("result: " + result);
	}
	static string ToCamelCase(string str)
	{
		
		StringBuilder newString = new StringBuilder();
		for(int i = 0; i < str.Length; i++)
		{
			if(str[i] != '-' && str[i] != '_')
			{
				newString.Append(str[i]);				
			}
			else
			{
				newString.Append(char.ToUpper(str[++i]));	
			}
		}
		Console.WriteLine(newString.ToString());
		return newString.ToString();
		/*
		var sb = new StringBuilder();
		for (int i = 0; i < str.Length; i++)
		{
		   if (str[i] != '-' && str[i] != '_') sb.Append(str[i]);
		   else sb.Append(char.ToUpper(str[++i]));
		}
		return sb.ToString();
		*/
	}
		
}