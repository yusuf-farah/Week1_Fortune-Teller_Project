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
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("in a number format what month where you born");
            int brMonth = int.Parse(Console.ReadLine());
            string saving;


            Console.WriteLine("what is your favorite ROYGBIV color if you don,t know what ROYGBIV is enter help");
            string ROYGBIV = Console.ReadLine().ToLower();
            string Red = "red";
            string orange = "orange";
            string Yellow = "yellow";
            String Green = "green";
            string Blue = "Blue";
            String Indigo = "Indigo";
            string Violet = "violet";


            if (ROYGBIV == "help")
            {
                Console.WriteLine("The colors are, Red, Orange, Yellow, Green, Blue, Indigo, and Violet");
            }
            else
            {
                Console.WriteLine("thank you ready for next question ");
            }

            Console.Write(" how many siblings do you have?");
            int Siblings = int.Parse(Console.ReadLine());
            
            int zeroSiblings = 0;
            int oneSiblings = 1;
            int twoSiblings = 2;
            int threeSiblings = 3;

            

            //part 2

            Console.WriteLine("you fortune will be display momenterly");

            Console.WriteLine(firstName + " " + lastNme );



            if (age %2==0)
            {
                Console.WriteLine("you will retire at the  age of 50");
            }
        else
            {
                Console.WriteLine("you will retire at the age of 45");
            }


            if ( brMonth == 1 && brMonth <= 4)

            {
                Console.WriteLine("you will have 2m dollar your bank by the time of your retirement age");
            }
            
            else if (brMonth == 5 && brMonth <= 8)
            {
                Console.WriteLine(" congrat you will have 200k in your bank at the time of retirement");
            }
            else if (brMonth == 9 && brMonth <= 12)
            {
                Console.WriteLine("you will 100k in your bank at the time of retirement ");
            }
            else
            {
                Console.WriteLine("oops! you will have zero dollar in your bank");

                if (Siblings == zeroSiblings)
                {
                    Console.WriteLine("you will have vacation home in the bahamas");
                }
                else if (Siblings == oneSiblings)
                {
                    Console.WriteLine("you will have vacation in Mugadishu");
                }
                else if (Siblings == twoSiblings)
                {
                    Console.WriteLine("you will have vacation home in Zinzibar");
                }
                else if (Siblings == threeSiblings)
                {
                    Console.WriteLine("you will have vacation home in Malta");
                }
                else
                {
                    Console.WriteLine(" you will have vacation in cleveland");
                }

                if (ROYGBIV== Red)

                {
                    Console.WriteLine("congrat you will be driving Liclon MKS");
                }


                if (ROYGBIV == orange)

                {
                    Console.WriteLine("congrat you will be driving new fully loaded cadilac ");
                }


                if (ROYGBIV == Yellow)

                {
                    Console.WriteLine("congrat you will be driving tahoe ");
                }


                if (ROYGBIV == Green)

                {
                    Console.WriteLine("congrat you will be driving mercury ");
                }

                if (ROYGBIV == Blue)

                {
                    Console.WriteLine("congrat you will be riding  yatch ");
                }

                if (ROYGBIV == Indigo)

                {
                    Console.WriteLine("congrat you will be flying private jicket ");
                }

                if (ROYGBIV == Violet)

                {
                    Console.WriteLine("congrat you will be driving luxury lexus  ");
                }
                else
                {
                    Console.WriteLine(" sorry you will be calling uber");
                        }














            }
        }
    }
}
