using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_One_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Fuck The World!");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a > 1)
            //    Console.WriteLine("What The Fuck");
            //else
            //    Console.WriteLine("Fuck The World");
            //Console.WriteLine(a);
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");//请输入你的名字
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome{userName}!");//打印你的名字
            Console.WriteLine("Now give me a number:");//请给我第一个数字
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");//请给我第二个数字
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + $"{firstNumber + secondNumber}.");//神**加法
            Console.WriteLine($"The result of subtracting {secondNumber} from " + $"{firstNumber} is {firstNumber - secondNumber}.");//神**减法
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} " + $"is {firstNumber * secondNumber}.");//神**乘法
            Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} " + $"is {firstNumber / secondNumber}.");//神**除法
            Console.WriteLine($"The remainder after dividing {firstNumber} by {secondNumber} is " + $"{firstNumber % secondNumber}.");//神**取余
            Console.ReadKey();
        }
    }
}
