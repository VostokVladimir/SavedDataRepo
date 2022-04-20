using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OOP
{

    public class SaveGame : GameController
    {   

        /// <summary>
        /// Класс предназначен для сохранения данных об игроке
        /// </summary>
        private PlayerInfo playerInfoQ;

        public SaveGame(PlayerInfo playerInfo)
        {
            playerInfoQ = playerInfo;
        }

        public void SaveGameonButton(PlayerInfo playerInfo)
        {  
           playerInfoQ = playerInfo;//складываем сюда текущие данные игрока, но они нулевые
           

            Debug.Log($"{playerInfoQ._NamePlayer}");
          
            var streamData = new StreamData();
            
           
            playerInfoQ._NamePlayer = playerInfo._NamePlayer;
            playerInfoQ._Playerscore = playerInfo._Playerscore;
            playerInfoQ._Helth = playerInfo._Helth;
            playerInfoQ.playerPosition.x = playerInfo.playerPosition.x;
            playerInfoQ.playerPosition.y = playerInfo.playerPosition.y;
            playerInfoQ.playerPosition.z = playerInfo.playerPosition.z;
            streamData.Save(playerInfoQ, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData3.txt");//Проблема 3 почему в текстовом файле не сохраняются обновленные данные в GameControllers?






        }
    }
}
