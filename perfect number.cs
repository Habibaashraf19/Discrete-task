using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int startingnumber,endingnumber,counter,z;
       Console.WriteLine("please enter the startingnumber(smallest)(positive number)");
       startingnumber =int.Parse(Console.ReadLine());
       
   
       Console.WriteLine("please enter the endingnumber(biggest)(positive number)");
       endingnumber =int.Parse(Console.ReadLine());
       
       for(z=startingnumber; z<=endingnumber; z++)
       {
         int sum=0;
         for(counter=1;counter<z;counter++)
       {
       if(z%counter==0)
       {
         sum=sum+counter;
       }
       }
       if(z==sum)
       Console.WriteLine(z);
       }
     }
   }
 }
