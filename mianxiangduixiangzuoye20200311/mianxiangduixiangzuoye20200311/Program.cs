using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mianxiangduixiangzuoye20200311
{
    class Program
    {
        static void Main(string[] args)
        {
           jisuanqi ao = new jisuanqi();
           Console.WriteLine("{0}", "请输入第一个数");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}", "请输入需要进行的运算符号");
           string c = Console.ReadLine();

            if (c != "+" && c != "-" && c != "*" && c != "/")
            {
                Console.WriteLine("{0}", "输入的操作错误");
                Console.WriteLine("{0}", "请重新输入运算符号");
                c = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0}", "请输入第二个数");
                double b = Convert.ToDouble(Console.ReadLine());
                ao.Equals(c, a, b);
            }
           
           Console.WriteLine("{0}", "请输入需要判断相等的第一个数");
            double a1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}", "请输入需要判断相等的第二个数");
            double b1 = Convert.ToDouble(Console.ReadLine());
            ao.Equals(a1, b1);
        }
    }
    class jisuanqi
    {
        public void Equals(string c, double a, double b)
        {
            Console.WriteLine("{0}", "结果为：");
            if (c == "+")
                Console.WriteLine("{0}",a+b); 
           else  if (c == "-")
                Console.WriteLine("{0}", a-b);
            else  if (c == "/")
                Console.WriteLine("{0}", a / b);
           else  if (c == "*")
                Console.WriteLine("{0}", a *b);

        }
        public void Equals(double a, double b)
        {

            if (a == b)
            { Console.WriteLine("{0}", "相等"); }
            else
            { Console.WriteLine("{0}", "不相等"); }
        }
    }
}

