﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Fortune_Teller_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // project part 1
            Console.WriteLine("thank you for coming let's go and start, so  what is your first name");
          string firstName = Console.ReadLine();


            Console.WriteLine(" great!! what is your last name");
            string lastNme = Console.ReadLine();


            Console.WriteLine(" awsome! and  how old are you");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("in a number format what month where you born");
            int brMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("what is your favorite ROYGBIV color if you don,t know what ROYGBIV is enter help");
            string ROYGBIV = Console.ReadLine().ToLower();
            if(ROYGBIV == "help")
            {
                Console.WriteLine("The colors are, Red, Orange, Yellow, Green, Blue, Indigo, and Violet");
            }
            else
            {
                Console.WriteLine("thank you ready for next question ");
            }

            Console.Write(" how many siblings do you have?");
            int Siblings = int.Parse(Console.ReadLine());
            //part 2
           
            if (age  % 2==1)
            {
                Console.WriteLine(" congratualtions!! you will retire at age of 45 years");
            }
        else
            {
                Console.WriteLine("you will retire in at the age of  50");
            }

            if (Siblings == 0)
            {
                Console.WriteLine(" awsome  your vacation home will be  in florida");
            }

            

             
            

            
             

            
            





        }
    }
}
