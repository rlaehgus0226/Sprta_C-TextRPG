using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryTextRPG
{
    internal class GameManager
    {
        static void Main(string[] args)
        {
            new GameManager();
        }

        public static GameManager Instance;

        BaseScene[] scenes;
        BaseScene preScene;
        BaseScene curScene;

        public GameManager()
        {
            Instance = this;

            scenes = new BaseScene[4];

            scenes[0] = new LobbyScene();
            scenes[1] = new StatusScene();
            scenes[2] = new InventoryScene();
            scenes[3] = new StoreScene();


            ChangeScene(0);
            Excute();
        }

        public void Excute()
        {
            while (true)
            {
                if (null != curScene)
                {
                    curScene.Excute();
                }
            }
        }

        public void ChangeScene(int index)
        {
            // 현재 씬이 있으면 이전 씬으로 설정 및 종료 처리
            if (null != curScene)
            {
                preScene = curScene;
                Console.Clear();
            }

            // 새로운 씬으로 변경 및 시작 처리
            curScene = scenes[index];
            curScene.Enter();
        }
    }
}
