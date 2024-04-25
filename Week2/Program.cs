namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Page1 info = new Page1();
            Page2 item = new Page2();
            Page3 buy = new Page3();

            while (true)
            {
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");

                Console.WriteLine("1. 상태보기 \n2. 인벤토리 \n3. 상점\n");
                Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");

                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        info.WatchStatus();
                        break;

                    case "2":
                        item.Inventory();
                        break;

                    case "3":
                        buy.Store();
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다\n");
                        break;
                }
            }
        }
    }
}
