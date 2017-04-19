﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_04_Mining_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalNumbers = float.Parse(Console.ReadLine());
            string decrypted = string.Empty;
            float totalValue = 0f;

            for (int i = 1; i <= totalNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digit1 = number / 100;
                int digit2 = (number / 10) % 10;
                int digit3 = number % 10;

                totalValue = totalValue + ((digit1 + digit2 + digit3) / totalNumbers);

                int ASCIIcode = 0;

                if (i % 2 == 0)
                {
                    ASCIIcode = ((digit1 * 10) + digit3) + digit2;
                }
                else
                {
                    ASCIIcode = ((digit1 * 10) + digit3) - digit2;
                }

                if ((ASCIIcode >= 65 && ASCIIcode <= 90)
                    || (ASCIIcode >= 97 && ASCIIcode <= 122))
                {
                    decrypted += (char)ASCIIcode;
                }
            }

            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}