
//use of typecasting and operators

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //use of implicit typecasting
        int myint=9;
        double mydouble=myint;//converts int to double
        Console.WriteLine($"{myint} {myint.GetType()}");
        //get type is used for getting the data type of the variable
        Console.WriteLine($"{mydouble} {mydouble.GetType()}");
        
        //use of explicit typecasting
        double mdouble=9.78;
        int mint =(int)mydouble;
        Console.WriteLine($"{mint} {mint.GetType()}");
        Console.WriteLine($"{mdouble} {mdouble.GetType()}");
        
        
        //Operators
        int c=10,d=30,sum=0;
        sum=(c+d);
        Console.WriteLine(sum);
        Console.WriteLine(c>d);
    }
}
