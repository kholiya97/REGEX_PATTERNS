using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGREXPATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            String pattern = "^[0-9]*[a-zA-Z]{3,}[a-zA-Z0-9]*$";
            string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
            string pincode = "^[0-9]{3}[]*[0-9]{3}$";
            string[] pinCodeArr = { "422010", "412109", "400820", "1452" };
            Program p = new Program();
            p.ValidateConseqCharacter(inputs, pattern);
            Console.WriteLine();
            p.ValidPincode(pinCodeArr, pincode);
            Console.Read();

        }
        public void ValidateConseqCharacter(string[] arr, string pattern)
        {
            Console.WriteLine("Validaing 3 Conseq Characters");
            Regex regex = new Regex(pattern);
            IterateLoop(arr, regex);
        }
        public void ValidPincode(string[] arr, string pincode)
        {
            Console.WriteLine("Validation Indian PIN Code");
            Regex regex = new Regex(pincode);
            IterateLoop(arr, regex);
        }
        public void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result == true)
                {
                    Console.WriteLine(arr[i] + "---->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "--->" + "Invalid");
                }
            }
        }
    }
}

 
