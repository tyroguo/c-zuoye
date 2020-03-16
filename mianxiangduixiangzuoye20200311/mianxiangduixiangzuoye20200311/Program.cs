using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2020316zuoy
{
    class Program
    {
        static void Main(string[] args)
        {
            jisuanqi ao = new jisuanqi();
            Console.WriteLine("{0}", "请输入第一个字符串");
            string a = Console.ReadLine();
            Console.WriteLine("{0}", "请输入需要进行的运算符号");
            string c = Console.ReadLine();

            if (c != "+" && c != "-")
            {
                Console.WriteLine("{0}", "输入的操作错误");
                Console.WriteLine("{0}", "请重新输入运算符号");
                c = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0}", "请输入第二个字符串");
                string b = Console.ReadLine();
                ao.Equals(c, a, b);
            }
        }
    }
    class jisuanqi
    {
        public void Equals(string c, string a, string b)
        {
            Console.WriteLine("{0}", "结果为：");
            if (c == "+")
                Console.WriteLine("{0}", a + b);
            else if (c == "-")
            {
                foreach (char bb in b)
                {
                    a = a.Replace(bb, ' ');
                }
                Console.WriteLine("{0}", a);

            }
        }
    }
}
