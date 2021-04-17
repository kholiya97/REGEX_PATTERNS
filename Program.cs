﻿using System;
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
            string pattern = "^([A-Za-z\\d-_\\+]+)(\\.[A-Za-z\\d-_]+)?@([a-zA-Z\\d]+)\\.([a-zA-Z]{2,4})(\\.[A-Za-z]{2,4})?$"; //pattern for email sample 
                                                                                                                              // ASSIGING SOME VALID SAMPLES
            string[] inputs = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com",
                              ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com",
                                "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };

            Program p = new Program(); // create object
            p.ValidPass(inputs, pattern);
            Console.WriteLine();
            Console.Read();
        }

        public void ValidPass(string[] arr, string pattern) //method to validate string
        {

            Console.WriteLine("Validation Of The email");
            Regex regex = new Regex(pattern);
            IterateLoop(arr, regex);  //calling method
        }

        public void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)    //check each name string using for loop 

            {

                bool result = regex.IsMatch(arr[i]);  //call the IsMatch metod to determine whether a match is present

                if (result == true)  ////check result is true or not using if and hence using bool
                {
                    Console.WriteLine(arr[i] + "---->" + "Valid email");

                }
                else
                {
                    Console.WriteLine(arr[i] + "--->" + "Invalid email");
                }

            }
        }


    }
}