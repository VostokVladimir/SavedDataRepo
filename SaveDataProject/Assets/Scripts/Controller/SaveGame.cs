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
        public void SaveGameonButton(PlayerInfo playerInfo)
        {
            playerInfoQ = playerInfo;//складываем сюда текущие данные игрока, но они нулевые
           

            Debug.Log($"{playerInfoQ._NamePlayer}");
            //var saved = new PlayerInfo("Lena", 34, 0);
            var streamData = new StreamData();
            //saved._NamePlayer = "Player8686896969";
            // Debug.Log($"Сейчас играет {saved._NamePlayer}");

            // saved.playerPosition.x = transform.position.x;
            // saved.playerPosition.y = transform.position.y;
            // saved.playerPosition.z = transform.position.z;
            // saved._Helth = 20;
            // saved._Playerscore = 0;
            // Debug.Log($"Сейчас играет {saved._Playerscore}");
            // streamData.Save(saved, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData3.txt");

            //playerInfoQ._NamePlayer = playerInfo._NamePlayer;
            //playerInfoQ._Playerscore = playerInfo._Playerscore;
            //playerInfoQ._Helth = playerInfo._Helth;
            //playerInfoQ.playerPosition.x = playerInfo.playerPosition.x;
            //playerInfoQ.playerPosition.y = playerInfo.playerPosition.y;
            //playerInfoQ.playerPosition.z = playerInfo.playerPosition.z;
            streamData.Save(playerInfoQ, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData3.txt");






        }
    }
}
