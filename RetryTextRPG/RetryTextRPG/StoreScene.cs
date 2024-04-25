using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryTextRPG
{
    internal class StoreScene : BaseScene
    {



        public override void Enter()
        {
            selectMenu = string.Empty;  //  선택한 값을 초기화
            ViewMenu();
        }



        public override void Excute()
        {
            selectMenu = Console.ReadLine();

            if (selectMenu == "0")
            {
                GameManager.Instance.ChangeScene(0);
            }
            else
            {
                selectMenu = string.Empty;
                Console.WriteLine("다시 입력해주세요");
            }
        }




        public override void ViewMenu()
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");


            Console.WriteLine("\n\n0. 로비");
        }
    }
}
