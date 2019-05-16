using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOriginPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine()); // 標準入力
            string[] str = Console.ReadLine().Split(' ');
            b = int.Parse(str[0]);
            c = int.Parse(str[1]);
        }
    }
}
