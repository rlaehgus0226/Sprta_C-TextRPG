using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryTextRPG
{
    internal class InventoryScene : BaseScene
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
            else if (selectMenu == "1")
            {
                // 1번 아이템 장착
                DataManager.Instance.EquipItem(DataManager.Items[0]);
            }
            else if (selectMenu == "2")
            {
                // 2번 아이템 장착
                DataManager.Instance.EquipItem(DataManager.Items[1]);
            }
            else if (selectMenu == "3")
            {
                // 3번 아이템 장착
                DataManager.Instance.EquipItem(DataManager.Items[2]);
            }
            else
            {
                selectMenu = string.Empty;
                Console.WriteLine("다시 입력해주세요");
            }


        }




        public override void ViewMenu()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]\n");

            Console.WriteLine("0. 돌아가기\n");

    
            for (int i = 0; i < DataManager.Items.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + DataManager.Items[i].Name);
            }

            Console.WriteLine("\n장착할 아이템을 선택해주세요.");

           
        }



    }
}
