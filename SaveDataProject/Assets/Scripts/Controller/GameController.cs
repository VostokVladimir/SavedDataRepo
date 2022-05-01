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
        public Vector3 currentposition;
        public BonusCurrentPositionInfo [] bonusPositionsInfoBox;
         



        public void Awake()


        {
          
            // catchControl = FindObjectOfType<PlayerBonusCatchControl>();//так можно создать если не пользоваться мышкой и не перетаскивать обьект в инспекторе
            catchControl._greatePlayerevent += PlayerBonusCatchControl__greatePlayerevent;
             
            
            
        }

        private PlayerInfo PlayerBonusCatchControl__greatePlayerevent(PlayerInfo player)
        {
            playerInfo = player;

            Debug.LogWarning($"Событие сработало создан обьект {playerInfo}");

            return playerInfo;
        }

        

             

        public void ButtonDown()
        {   currentposition = catchControl.transform.position;
            GetDataPlayer(playerInfo,currentposition);
            GetDataBonusesPositionBonuses();
        }

/// <summary>
/// Метод для сохранения позиций бонусов на сцене
/// </summary>
        public void GetDataBonusesPositionBonuses()
        {
            bonusPositionsInfoBox=FindObjectsOfType<BonusCurrentPositionInfo>();
           
            Debug.Log(bonusPositionsInfoBox.Length);
            for (int i= 0;  i<bonusPositionsInfoBox.Length; i++)
            {
                var streamdata = new StreamData();
                var saved = bonusPositionsInfoBox[i];
                //Debug.Log($"Координаты бонуса {saved.positionBonus.x},{saved.positionBonus.y}, {saved.positionBonus.z}");
                streamdata.SaveBonusData(saved, $"C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData{i}.txt");
            }

        }


        public static void GetDataPlayer(PlayerInfo playerInfo,Vector3 position)
        {
            var streamdata = new StreamData();
            playerInfo.PositionPlayer.X = position.x;
            playerInfo.PositionPlayer.Y = position.y;
            playerInfo.PositionPlayer.Z = position.z;
            var saved = playerInfo;
            streamdata.Save(saved, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData.txt");
        }

    }
}
