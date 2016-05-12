using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_s2016_lesson1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //call the hello world to console method
            HelloWorldToConsole(); 
        }

        /*
         * @description: This is my Hello World Method
         * @method: HelloWorldToConsole
         * @return: {string} HelloWorldString
         */
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString; 
        }
    }
}
