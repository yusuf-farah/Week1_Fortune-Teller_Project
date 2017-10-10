using System;
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
           

            Console.WriteLine(" great!! what is your last name?");
            string lastNme = Console.ReadLine();
            
            Console.WriteLine(" awsome! and  how old are you");
            int retirementAge = int.Parse(Console.ReadLine());
           

            Console.WriteLine("in a number format what month where you born");
            int brMonth = int.Parse(Console.ReadLine());
            int saving;
            

            if (brMonth >= 1 && brMonth < 4)
            {
               saving = 200;
            }
            else if (brMonth >= 5 && brMonth < 8)
            {
                saving = 45000;
            }
            else if (brMonth >= 9 && brMonth < 12)
            {
                saving = 34;
            }
            else
            {
                saving = 0;
            }

            Console.WriteLine("what is your favorite ROYGBIV color?");
            Console.WriteLine("if you don,t know what ROYGBIV is enter (help)");
            
                string favoritecolor = Console.ReadLine().ToLower();
                string modeTran = Console.ReadLine();
            

            if (favoritecolor == "help")
            {
                Console.WriteLine("The colors are, Red, Orange, Yellow, Green, Blue, Indigo, and Violet");
                Console.WriteLine("please enter your favorite color");
                string ROYGBIV = Console.ReadLine().ToUpper();

            }

            switch (favoritecolor)
            { case "red":
                    modeTran = "mercedes";
                    break;
                case "orange":
                    modeTran = "lexus";
                    break;
                case "yellow":
                    modeTran = "ross ross";
                    break;
                case "green":
                    modeTran = "yatchs";
                    break;
                case "blue":
                    modeTran = "bmw";
                    break;
                case "indigo":
                    modeTran = "audi";
                    break;
                case "violet":
                    modeTran = "motocycle";
                    break;

                default:
                    modeTran = "you gotta walk body";
                    break;

            }
            Console.Write(" how many siblings do you have?");
            int Siblings = int.Parse(Console.ReadLine().ToLower());
            string vacationHome = Console.ReadLine();
            Console.WriteLine("you fortune will be display momenterly");

            Console.WriteLine( firstName + " " + lastNme + " will retire in "+ retirementAge + "  in the bank " +saving + "vacation home " +vacationHome+ " your ride "  + modeTran);


            if (retirementAge % 2 == 0)
            {
                retirementAge = 50;
            }
            else
            {
                retirementAge = 45;
            }

            if (Siblings == 0)
            {
                vacationHome = "florida";
            }
            else if (Siblings == 1)
            {
                vacationHome = "zinzibar";

            }
            else if (Siblings == 2)
            {
                vacationHome = "bahamas";
            }
            else if (Siblings > 3)
            {
                vacationHome = "tanzania";
            }
            else if (Siblings <= 0)
            {
                vacationHome = "bad place";
            }
            else
            {
                vacationHome = "haha you bad lucky sorry";
            }

                //Console.WriteLine("you fortune will be display momenterly");

                //Console.WriteLine(firstName + " " + lastNme + "will retire in retirementage" + ". " + "with saving in the bank " + " vacationHome "+"modeTran");


                //if (retirementAge % 2 == 0)
                //{
                //    retirementAge = 50;
                //}
                //else
                //{
                //    retirementAge = 45;
                //}










            }
        }
    }
    
