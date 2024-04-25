using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Page2
    {
        public void Inventory()
        {
            Page2equip weapon = new Page2equip();

            Console.WriteLine("인벤토리\n보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("\n[아이템 목록]\n");
            Console.WriteLine("1. 장착 관리\n0. 나가기");

            Console.WriteLine("\n원하시는 행동을 입력해주세요.\n>>");
            string num = Console.ReadLine();

            switch (num)
            {
                case "1":

                    weapon.Closet();

                    break;

                case "0":
                    Console.WriteLine("나가기");
                    break;
            }
        }
    }
}
