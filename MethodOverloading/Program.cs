﻿namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal decimal1, int decimal2)
        {
            return decimal1 + decimal2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        //* the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers
        //* plus the word "dollars" at the end of the string./*
            
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if(isTrue)
            {
                sum = num1 + num2;

                //if(sum == 1)
                //{
               //     response = $"{sum} dollar.";
                //}
                //else
                //{
                //    response = $"{sum} dollars.";
                //}

                response = (sum == 1) ? $"{sum} dollar." : $"{sum} dollars.";

            }
            
            return response;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));

            Console.WriteLine();

            Console.WriteLine(Add(5, 7, true));

            Console.WriteLine();

            Console.WriteLine(Add(-6, 3, true));
        }
    }
    
}
