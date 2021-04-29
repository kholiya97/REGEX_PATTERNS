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
            string Name = "^[A-Z]{1}[A-Za-z]{2,}$"; //pattern using for string and string has minimum 3 char.
            string[] Namearr = { "Himanshu", "Harshpal", "Gaurav", "Aa", "Sameer" };  //Array of name

            Program p = new Program(); // create object
            p.ValidName(Namearr, Name);
            Console.WriteLine();
            Console.Read();
        }

        public void ValidName(string[] arr, string Name) //method to validate string
        {
            Console.WriteLine("Validation Of The Name");
            Regex regex = new Regex(Name);
            IterateLoop(arr, regex);  //calling method
        }

        public void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)    //use for loop 

            {
                bool result = regex.IsMatch(arr[i]);
                if (result == true)  //check result is true or not using if and hence using bool
                {
                    Console.WriteLine(arr[i] + "---->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "--->" + "Invalid Name");
                }
            } //end loop
        }
    }
}
