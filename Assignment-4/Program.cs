using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[] { "Boat","House","Cat","river","cupboard" };
            Console.WriteLine("Words To Plural : ");
            foreach (var item in input)
            {
                Console.WriteLine(item+"s");
            }
            Console.WriteLine("\nReplaced House to Home : ");
            input[1] = "home";
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAdded new word : ");
            //input[5] = "sp";
            //input.SetValue("SP",5);
            List<string> newword = input.ToList();
            newword.Add("SP");
            input = newword.ToArray();
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nWord with Length 7 : ");
            var wordlen7 = Array.FindAll(input, i => i.Length == 7);
            foreach (var item in wordlen7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nWord at 3rd Position : {input[2]}");
            Console.WriteLine("\nWord in Ascending Order");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.WriteLine("\nWord in Reverses Order");
            
            foreach (var item in input.Reverse())
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
