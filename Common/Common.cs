using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    public static class Common
    {
        public static string GetString(string msg, string errMsg = "Input cannot be empty")
        {
            Console.Write(msg);
            string result;
            while (string.IsNullOrEmpty(result = Console.ReadLine()))
            {
                Console.WriteLine(errMsg);
                Console.Write(msg);
            }
            return result;
        }

        public static string GetConfirm(string msg, string errMsg = "Please choose Yes[Y] or No[N]")
        {
            //not poperly implemented
            Console.Write(msg);
            string result;
            while (string.IsNullOrEmpty(result = Console.ReadLine()))
            {
                if (result == "Y")
                {
                    Console.WriteLine(errMsg);
                    Console.Write(msg);
                }
                if (result == "y")
                {
                    Console.WriteLine(errMsg);
                    Console.Write(msg.ToUpper());
                }
                if (result == "N")
                {
                    Console.WriteLine(errMsg);
                    Console.Write(msg);
                }
                if (result == "n")
                {
                    Console.WriteLine(errMsg);
                    Console.Write(msg.ToUpper());
                }
                else
                {
                    
                }
            }
            return result;
        }

        public static int GetInt(string msg, string errMsg = "Input cannot be empty and has to be digit")
        {
            int result = 0;
            Console.Write(msg);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine(errMsg);
                Console.Write(msg);
            }
            return result;
        }

        public static double GetDouble(string msg, string errMsg = "Input cannot be empty and has to be digit (00,00)")
        {
            double result = 00.00;
            Console.Write(msg);
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine(errMsg);
                Console.Write(msg);
            }
            return result;
        }
    }
}
