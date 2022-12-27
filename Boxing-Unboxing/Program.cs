// See https://aka.ms/new-console-template for more information
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        List<object> objList = new List<object>();
        objList.Add(7);
        objList.Add(28);
        objList.Add(-1);
        objList.Add(true);
        objList.Add("chair");
        int x =0;
        int cast;
        foreach (object obj in objList)
        {
            Console.Write(" " + obj);
            if (obj is int)
            {
                cast=Convert.ToInt32(obj);
                x=x+cast;
            }
        }
        Console.WriteLine("\nThe sum of integer values is :"+x);



    }
}