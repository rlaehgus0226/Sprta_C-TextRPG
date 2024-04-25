using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace RetryTextRPG
{


    
    internal class StatusScene : BaseScene
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
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

            Console.WriteLine("레벨 : " + DataManager.Instance.level);
            Console.WriteLine("직업 : " + DataManager.Instance.job);
            Console.WriteLine("공격력 : " + DataManager.Instance.attack);
            Console.WriteLine("방어력 : " + DataManager.Instance.defence);
            Console.WriteLine("체력 : " + DataManager.Instance.hp);
            Console.WriteLine("골드 : " + DataManager.Instance.gold);

            Console.WriteLine("\n\n0. 로비");
        }

    }
}
