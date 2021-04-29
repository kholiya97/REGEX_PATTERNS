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
            string pattern = "^[A-Z]{1}[a-z]{7,}$"; //pattern for password minimum 8 char.
            string pattern = "^[A-Za-z0-9]{8,}$"; //pattern for password minimum 8 char.

            Program p = new Program(); // create object
            p.ValidPass(pattern);
            Console.WriteLine();
            Console.Read();
        }

        public void ValidPass(string pattern) //method to validate string
        {

            Console.WriteLine("Validation Of The Password");
            Regex regex = new Regex(pattern);
            IterateLoop(regex);  //calling method
        }

        public void IterateLoop(Regex regex)
        {
            int i = 0; //initialize i value
            while (i != 1)
            {
                Console.WriteLine("Enter Password");
                string Password = Console.ReadLine();
                bool result = regex.IsMatch(Password);  //call the IsMatch metod to determine whether a match is present

                if (result == true)  ////check result is true or not using if and hence using bool
                {
                    Console.WriteLine("Valid password");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Enter minimum eight character and use atlest one Uppercase");
                }

            }
          
        {
            int i = 0; //initialize i value
            while (i != 1)
            {
                Console.WriteLine("Enter Password");
                string Password = Console.ReadLine();
                bool result = regex.IsMatch(Password);  //call the IsMatch metod to determine whether a match is present

                if (result == true)  ////check result is true or not using if and hence using bool
                {
                    Console.WriteLine("Valid password");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Enter minimum eight character");
                }

            }

            string Pattern = "^([a-z]{3,})([.]{0,1}[a-z]*)@([a-z]{2}).([a-z]{2})([.]{1}[a-z]{2}){0,1}$"; //pattern using for email.

            Program p = new Program(); // create object
            p.ValidName(Pattern);

            string lastName = "^[A-Z]{1}[A-Za-z]{2,}$"; //pattern using for string and string has minimum 3 char.
            string[] lastNamearr = { "Kholiya", "Singh", "Dhami", "Sharma", "Ah" };  //Define some  name strings.

            Program p = new Program(); // create object
            p.ValidName(lastNamearr, lastName);

            string Name = "^[A-Z]{1}[A-Za-z]{2,}$"; //pattern using for string and string has minimum 3 char.
            string[] Namearr = { "Himanshu", "Harshpal", "Gaurav", "Aa", "Sameer" };  //Array of name

            Program p = new Program(); // create object
            p.ValidName(Namearr, Name);

            Console.WriteLine();
            Console.Read();
        }

        public void ValidName(string Pattern) //method to validate string
        {
            Console.WriteLine("Validation Of The Email");
            Regex regex = new Regex(Pattern);
            IterateLoop(regex);  //calling method
        }

        public void IterateLoop(Regex regex)
        {
            int i = 0; //initialize i value
            while (i != 1)
            {
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();
                bool result = regex.IsMatch(email);  //call the IsMatch metod to determine whether a match is present

                if (result == true)  ////check result is true or not using if and hence using bool
                {
                    Console.WriteLine("Valid email");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Enter email in this format : abc.xyz@bl.co.in");
                }

            }
          
        public void ValidName(string[] arr, string lastName) //method to validate string
        {
            Console.WriteLine("Validation Of The Name");
            Regex regex = new Regex(lastName);

        public void ValidName(string[] arr, string Name) //method to validate string
        {
            Console.WriteLine("Validation Of The Name");
            Regex regex = new Regex(Name);

            IterateLoop(arr, regex);  //calling method
        }

        public void IterateLoop(string[] arr, Regex regex)
        {

            for (int i = 0; i < arr.Length; i++)    //check each name string using for loop 

            {
                bool result = regex.IsMatch(arr[i]);   //call the IsMatch metod to determine whether a match is present

            for (int i = 0; i < arr.Length; i++)    //use for loop 

            {
                bool result = regex.IsMatch(arr[i]);

                if (result == true)  //check result is true or not using if and hence using bool
                {
                    Console.WriteLine(arr[i] + "---->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "--->" + "Invalid LastName");

                    Console.WriteLine(arr[i] + "--->" + "Invalid Name");
                }
            } //end loop
        }
    }
}