using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace RetryTextRPG
{
    internal class DataManager
    {

        public static DataManager Instance = new DataManager();

        public void EquipItem (Item item)
        {
            if (!item.isEquip)
            {
                // 아이템이 장착되지 않았다면 장착 처리
                item.isEquip = true;
                attack += item.Attack;
                defence += item.Defence;
                hp += item.HP;
                Console.WriteLine($"{item.Name}을(를) 장착했습니다.");
            }
            else
            {
                Console.WriteLine($"{item.Name}은(는) 이미 장착되어 있습니다.");
            }
        }





        // 캐릭터 정보
        // public string[] jobs = { "전사", "마법사" };

        public string job = "전사";        
        public int level = 1;
        public int attack = 10;
        public int defence = 0;
        public int hp = 100;

        public int? equipIndex = null;

        // 재화 정보
        public int gold = 10000;

        // 아이템 정보
        List<Item> items = new List<Item>();



        public static List<Item> Items { get; private set; }

        static DataManager()
        {
            Items = new List<Item>
            {
                new Item("무쇠갑옷", "무쇠로 만들어져 튼튼하 갑옷입니다.", 125, 888, 2300),
                new Item("스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 558, 111, 10),
                new Item("낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", 250, 250, 999),
                new Item("짧은 검", "짧다.", 11, 5, 10),
                new Item("긴 검", "길다.", 111, 555, 888),
                new Item("종이갑옷", "튼튼하다.", 0, -55, -1000)
            };
        }

    }
}


