using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace likeswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학년을 입력하세요: ");
            int level = int.Parse(Console.ReadLine());

            Console.Write("수강해야 하는 전공 학점: ");
            switch(level)
            {
                case 1:
                    Console.WriteLine("12학점");
                    break;
                case 2:
                case 4:
                    Console.WriteLine("18학점");
                    break;
                case 3:
                    Console.WriteLine("10학점");
                    break;
            }
        }
    }
}
