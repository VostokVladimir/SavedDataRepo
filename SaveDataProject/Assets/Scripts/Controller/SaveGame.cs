using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OOP
{

    public class SaveGame : GameController
    {
        private PlayerInfo playerInfo;
        public void SaveGameonButton()
        {
            var saved = new PlayerInfo("Lena", 34, 0);
            var streamData = new StreamData();
            saved._NamePlayer = "Player8686896969";
            Debug.Log($"Сейчас играет {saved._NamePlayer}");

            saved.playerPosition.x = transform.position.x;
            saved.playerPosition.y = transform.position.y;
            saved.playerPosition.z = transform.position.z;
            saved._Helth = 20;
            saved._Playerscore = 0;
            Debug.Log($"Сейчас играет {saved._Playerscore}");
            streamData.Save(saved, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData3.txt");
        }
    }
}
