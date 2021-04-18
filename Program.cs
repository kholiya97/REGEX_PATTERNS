using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {     //Entery point 

            Console.WriteLine("-------Welcome To User Registration--------");
            Console.WriteLine();
            string Pattern = "^91\\s[1-9]{1}[0-9]{9}$"; //pattern using for email.
            string[] inputs1 = { "91 7002285211", "91 90000007", "9876543211", "92 8907562431", "990088776655", "990088awek678543" };

            Program p = new Program(); // create object
            p.Validnumber(inputs1, Pattern);
            Console.WriteLine();
            Console.Read();
        }

        public void Validnumber(string[] arr, string Pattern) //method to validate string
        {
            Console.WriteLine("Validation Of The Email");
            Regex regex = new Regex(Pattern);
            IterateLoop(arr, regex);  //calling method
        }

        public void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)    //check each name string using for loop 

            {

                bool result = regex.IsMatch(arr[i]);  //call the IsMatch metod to determine whether a match is present

                if (result == true)  ////check result is true or not using if and hence using bool
                {
                    Console.WriteLine(arr[i] + "---->" + "Valid");

                }
                else
                {
                    Console.WriteLine(arr[i] + "--->" + "Invalid MobileNumber");
                }

            }
        }
    }
}