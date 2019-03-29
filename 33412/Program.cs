using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp3
{
    public class Program
    {
        public char yuf(int x)
        {
            char f='+';
            if (x == 1)
                f = '+';
            else if (x == 2)
                f = '-';
            else if (x == 3)
                f = '*';
            else if (x == 4)
                f = '/';
            return f;
        }
        public static string scss()
        {
            int a, b;
            string sz = Convert.ToString(' ');
            Random arandom = new Random();
            a =arandom .Next(2, 4);//确定符号个数
            Thread.Sleep(1);
            b = a + 1;//确定数字个数
            int[] s = new int[b];
            int[] f = new int[a];
            char[] ff = new char[a];
            
            for (int i=0;i<a;i++)//生成一个算式但少一个数字
            {
                s[i] = arandom.Next(0, 101);
                Thread.Sleep(1);
                f[i] = arandom.Next(1, 5);
                Thread.Sleep(1);
                //ff[i] = yuf(f[i]);
                sz = sz + s[i] + ff[i];
            }
            int bz = arandom .Next(0, 101);
            Thread.Sleep(1);
            sz = sz + bz;//补足缺少的一个数字
            return sz;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要的运算题目数量：");
            int sl;
            sl =Convert.ToInt16 ( Console.ReadLine());
            double[] s = new double[sl];
            if(sl<=0)
            {
                Console.WriteLine("输入错误！请重新输入：");
                sl= Convert.ToInt16(Console.ReadLine());
            }
            for (int i=0;i<sl;)
            { 
                string[] sz = new string[sl];
                sz[i] = scss();
                s[i] =Convert .ToDouble ( new System.Data.DataTable().Compute(sz[i],""));
                if (s[i] < 0 || s[i] % 2 != 1 && s[i] % 2 != 0)//判断算式是否正确
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(sz[i]);
                    i++;
                }
                
            }
           Console.WriteLine("答案如下：");
            for(int i = 0; i < sl; i++)
            {
                Console.WriteLine(i+1 + "." + s[i]);
            }
        }
    }
}
