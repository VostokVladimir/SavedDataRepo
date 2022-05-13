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
        public string dataStringPosition;
        public GameObject spawncontroller;
             

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
            SetDataPlayer(playerInfo,currentposition);
           
        }

/// <summary>
/// Метод для сохранения позиций бонусов на сцене
/// </summary>
        public void GetDataBonusesPositionBonuses()
        {
            bonusPositionsInfoBox = FindObjectsOfType<BonusCurrentPositionInfo>();//складываем все позиции в массив векторов

           
            DataBonusPosition to = new DataBonusPosition(bonusPositionsInfoBox);//складываем массив со  всеми позициями в структуру
            dataStringPosition = JsonUtility.ToJson(to);//структуру превращаем в строку и складываем в джсон
            print(dataStringPosition);
            

        }
                /// <summary>
                /// Метод для сохранения данных о местоположении игрока на сцене
                /// </summary>
                /// <param name="playerInfo"></param>
                /// <param name="position"></param>
        public static void SetDataPlayer(PlayerInfo playerInfo,Vector3 position)
        {
            var streamdata = new StreamData();
            playerInfo.PositionPlayer.X = position.x;
            playerInfo.PositionPlayer.Y = position.y;
            playerInfo.PositionPlayer.Z = position.z;
            var saved = playerInfo;
            streamdata.Save(saved, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData.txt");
        }

        /// <summary>
        /// Метод для загрузки данных о местоположении бонусов на сцене
        /// </summary>
        /// <param name="value"></param>
        public static void SetDataBonus(string value)
        {
          DataBonusPosition from = JsonUtility.FromJson<DataBonusPosition>(value);//поолучен массив структур  с позициями 
            print(from.v3s);
          //DataBonusPosition from = JsonUtility.FromJson<DataBonusPosition>(dataStringPosition);
            for(int i=0;i>=from.v3s.Length;i++)
            {
                print(from.v3s[i]);
            }
            
        }


        public void LoadBonuses()
        {
            if(dataStringPosition!=null)
            SetDataBonus(dataStringPosition);
                    
                         
                                 
        }
             
    }
}
