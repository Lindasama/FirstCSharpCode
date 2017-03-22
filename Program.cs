using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    /// <summary>
    /// static表示“静态的”。 string表示“字符串”数据类型。 using常常写在类的前面，用来引用其他命名空间中的类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            Console.WriteLine(b);

            int days = DateTime.Now.DayOfYear;


            b = (days % 2 == 0);

            if (b)
            {
                Console.WriteLine("days is an even number");
            }
            else
            {
                Console.WriteLine("days is an odd number");
            }
        }
    }
}
