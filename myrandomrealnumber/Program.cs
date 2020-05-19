using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ran = random.Next();
            int num = 0;

            while (true) {
                Console.Write("숫자를 입력해주세요 : ");
                num = int.Parse(Console.ReadLine());

                if (num == ran)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
                else if (num > ran)
                    Console.WriteLine(num + " 보다는 작은 숫자입니다.");
                else if(num<ran)
                    Console.WriteLine(num + " 보다는 큰 숫자입니다.");


            }
        }
    }
}
