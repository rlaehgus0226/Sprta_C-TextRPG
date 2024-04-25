using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryTextRPG
{
    internal class LobbyScene : BaseScene
    {
        public override void Enter()
        {
            selectMenu = string.Empty;  //  선택한 값을 초기화
            ViewMenu();
        }



        public override void Excute()
        {
            selectMenu = Console.ReadLine();

            if (selectMenu == "1")
            {
                GameManager.Instance.ChangeScene(1);
            }
            else if (selectMenu == "2")
            {
                GameManager.Instance.ChangeScene(2);
            }
            else if (selectMenu == "3")
            {
                GameManager.Instance.ChangeScene(3);
            }
            else
            {
                selectMenu = string.Empty;
                Console.WriteLine("다시 입력해주세요");
            }
        }




        public override void ViewMenu()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점\n");

            Console.WriteLine("원하시는 행동을 입력해주세요");
        }
    }
}
