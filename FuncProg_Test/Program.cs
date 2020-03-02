using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FuncProg_Test
{
    public static class Program
    {
        static void Main(string[] args)
        {
           
            var sentence = "heloo darkness my old friend";
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 6, 8, 8, 6, 9 };
            var grades = new[] { 87.5, 88.5, 60.5, 90.5, 88.5 };
            var words = new[] {"abc","abc","abc","cab","cba","bca" };
            //num1
            Console.WriteLine(sentence.Capitalize());
            //num2
            Console.WriteLine(sentence.SnakeCase());
            //num3
            Console.WriteLine(sentence.KebabCase());
            //num4
            Console.WriteLine(numbers.Most());
            Console.WriteLine(grades.Most());
            Console.WriteLine(words.Most());
            //num6
            Console.WriteLine(sentence.TrimS(8));
            //num7
            Console.WriteLine(sentence.TrimW(3));
        }
    }


    
}
