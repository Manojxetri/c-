// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("hello world");
        Console.ReadLine();
        
        //use of integer data type
        int num=2;
        int exnum=3;
        Console.WriteLine(num);
        Console.ReadLine();
        
        //diplaying both num and exnum
        Console.WriteLine(num + " " +exnum);
        
        //use of string datatype
        string firstname="manoj";
        string secondname="khanal";
        
        //displaying the string variable by combining first name and last name
        Console.WriteLine("My name is " +firstname +" " +secondname);
        Console.ReadLine();
        
        //use of f at last for declaring the float number
        float num2=43.35f;
        
        //use of d at last for declaring the double
        double num3=12333.33333d;
        Console.WriteLine(num2+num3);
        
        //use of boolean data type i.e used to display true or false
        bool y=true;
        Console.WriteLine(y);
        
        //use of char data type
        char name='m';
        Console.WriteLine(name);
    }
}
