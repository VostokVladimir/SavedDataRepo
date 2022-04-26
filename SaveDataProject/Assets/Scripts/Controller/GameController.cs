using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OOP
{
    public class GameController :MonoBehaviour
    {
        public PlayerBonusCatchControl catchControl;
        public PlayerInfo playerInfo;
        
                 
        public void Awake()


        {
            PlayerBonusCatchControl playerBonusCatchControl = new PlayerBonusCatchControl();
            playerBonusCatchControl._greatePlayerevent += PlayerBonusCatchControl__greatePlayerevent;
            
            
        }

        private PlayerInfo PlayerBonusCatchControl__greatePlayerevent(PlayerInfo player)
        {
            playerInfo = player;
            return playerInfo;
            Debug.LogWarning($"Событие сработало создан обьект {playerInfo}");
        }

        


        void Update()
        {
           

            Debug.Log($"из апдейта счет  {playerInfo._Playerscore}");// Проблема 2 почему в дебаге два значения 0 и обновленное ?
        }


        public void ButtonDown()
        {
            GetDataPlayer(playerInfo);
        }


        public static void GetDataPlayer(PlayerInfo playerInfo)//на данном методе кнопка Save на канвасе. Не могу сюда передать обновленные данные по Обьекту игрока
        {
            var streamdata = new StreamData();
            var saved = new PlayerInfo {_NamePlayer=playerInfo._NamePlayer,_Playerscore=playerInfo._Playerscore};
            saved._NamePlayer = playerInfo._NamePlayer;
            saved._Playerscore = playerInfo._Playerscore;
           
            

             Debug.Log($"счет игрока составляет { saved._Playerscore}");//проблема3  почему при нажатии кнопки в дебаге выводит значение 0 при увеличении количества бонусов, и не делает обновление значения ?
             streamdata.Save(saved, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData3.txt");//Проблема 4 почему в текстовом файле не сохраняются обновленные данные в GameControllers?
        }

    }
}
