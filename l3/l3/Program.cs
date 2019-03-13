using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- ввести А");
            Console.WriteLine("- ввести В");
            Console.WriteLine("- выполнить операцию “+”");
            Console.WriteLine("- выполнить операцию “-” ");
            Console.WriteLine("- выполнить операцию “*”");
            Console.WriteLine("- выполнить операцию “/”");
        }
    }

    public static int add(int a, int b)
    {
        return a + b;
    }

    public static int inputA(int input)
    {


        input = Convert.ToInt32(Console.ReadLine());
    }


    public static int inputB(int input)
    {


        input = Convert.ToInt32(Console.ReadLine());
    }


    public static int mul(int a, int b)
    {
        return a * b;
    }

}
