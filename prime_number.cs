using System;
using System.Linq;

 namespace prime_number 
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       
       int num1 ,num2 ,num3;
       
       Console.WriteLine("please enter the starting(smallest)number");
       num1 = int.Parse(Console.ReadLine());
       
       Console.WriteLine("please enter the ending (biggest) number");
       num2 = int.Parse(Console.ReadLine());
       
       for(int z=num1; z<=num2 ; z++)
       {
         for(num3=2; num3<z/2; num3++)
       {
       if(z%num3==0)
       break;
       }
       if(z%num3!=0 && z!=1 && z!=-1)
       Console.WriteLine(z);
       }
     }
   }
 }

