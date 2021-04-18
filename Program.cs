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
            string lastName = "^[A-Z]{1}[A-Za-z]{2,}$"; //pattern using for string and string has minimum 3 char.
            string[] lastNamearr = { "Kholiya", "Singh", "Dhami", "Sharma", "Ah" };  //Define some  name strings.

            Program p = new Program(); // create object
            p.ValidName(lastNamearr, lastName);
            Console.WriteLine();
            Console.Read();
        }

        public void ValidName(string[] arr, string lastName) //method to validate string
        {
            Console.WriteLine("Validation Of The Name");
            Regex regex = new Regex(lastName);
            IterateLoop(arr, regex);  //calling method
        }

        public void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)    //check each name string using for loop 

            {
                bool result = regex.IsMatch(arr[i]);   //call the IsMatch metod to determine whether a match is present
                if (result == true)  //check result is true or not using if and hence using bool
                {
                    Console.WriteLine(arr[i] + "---->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "--->" + "Invalid LastName");
                }
            } //end loop
        }
    }
}