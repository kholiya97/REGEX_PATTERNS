using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGREXPATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            string pincode = "^[0-9]{3}[]*[0-9]{3}$";
            string[] pinCodeArr = { "422010", "482109", "40C82K", "145c22" };
            Program p = new Program();

            p.ValidPincode(pinCodeArr, pincode);
            Console.WriteLine();
            Console.Read();

        }

        public void ValidPincode(string[] arr, string pincode)
        {
            Console.WriteLine("Validation Indian PIN Code");
            REGREX regex = new REGREX(pincode);
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
