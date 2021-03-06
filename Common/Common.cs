using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    public static class Common
    {
        public static string GetString(string msg, string errMsg = "Input cannot be empty.")
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

        public static string GetConfirm(string msg, string errMsg = "Please enter Yes[Y] or No[N].")
        {
            Console.Write(msg);
            string result;
            while (!string.IsNullOrEmpty(result = Console.ReadLine()))
            {
                if (result != "Y" && result != "y" && result != "N" && result != "n")
                {
                    Console.WriteLine(errMsg);
                    Console.Write(msg);
                }
                else
                {
                    return result.ToUpper();
                }
            }
            return result;
        }

        public static string GetGameType(string msg, string errMsg = "Please enter correct game type [RPG],[Survival],[FPS],[Action].")
        {
            Console.Write(msg);
            string result;
            while (!string.IsNullOrEmpty(result = Console.ReadLine()))
            {
                if (result != "RPG" && result != "rpg" && result != "Survival" && result != "survival" && result != "Action" && result != "action" && result != "FPS" && result != "fps")
                {
                    Console.WriteLine(errMsg);
                    Console.Write(msg);
                }
                else
                {
                    return result;
                }
            }
            return result;
        }

        public static int GetInt(string msg, string errMsg = "Input cannot be empty and has to be digit.")
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

        public static double GetDouble(string msg, string errMsg = "Input cannot be empty and has to be digit (00,00).")
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
