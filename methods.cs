// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace methods
{
    internal class Program{
        // void print(){
        //     Console.WriteLine("hello world");
        // }
        // static int sum(int a,int b){
        //     return a+b;
        // static void cal(ref int j)
        // {
        //     j=50;
        // }
        // }
        // static void calculator(int x ,int y,out int sum,out int product){
        //     sum=x+y;
        //     product=x*y;
            
        // }
        static void ParaMethods(params int []i){
            foreach(var m in i)
            {
                Console.WriteLine("this is {0}",m);
            }
           // for (int a=0;a<i.Length;a++){
             //   Console.WriteLine("this is {0}",i[a]);
            //}
        }
        static void Main(string[] args){
            // Program program1=new Program();
            // program1.print();
            // Console.WriteLine("enter two numbers");
            // int a=Convert.ToInt32(Console.ReadLine());
            // int b=Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(sum(a,b));
            // Console.ReadLine();
            
            
            //method parameters
            //pass by value
        //     int i=0;
        //     call(ref i);
        //     Console.WriteLine(i);
        //     Console.ReadLine();
    //     int a=0;
    //     int b=0;
    //     calculator(2,3,out a,out b);
    //     Console.WriteLine($"The sum is {a} and product is {b}");
    //     Console.ReadLine();
    int [] ints =new int[2];
    ints[0]=1;
    ints[1]=2;
    ParaMethods();
    ParaMethods(1,2,3,5,4,3);
    Console.ReadLine();
      }
    }        
}
