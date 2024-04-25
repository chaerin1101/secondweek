using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Page1
    {
        public void WatchStatus()
        {
            Console.WriteLine("상태보기\n캐릭터의 정보가 표시됩니다.\n");
            
            Console.WriteLine("이름 : ");
            Console.WriteLine("Lv. 01");
            Console.WriteLine("Chad (전사)");
            Console.WriteLine("공격력 : 10");
            Console.WriteLine("방어력 : 5");
            Console.WriteLine("체력 : 100");
            Console.WriteLine("Gold : 1500 G");

            Console.WriteLine("\n0. 나가기\n");
            Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");

        }
    }
}
