using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OOP
{
    public class GameController : MonoBehaviour
    {
        
        private References references;
        public PlayerInfo playerInfo;
        public float score;
        //public SaveGame game;
        
        
         

        
         

        public void Awake()


        {
            playerInfo = new PlayerInfo();
            playerInfo._NamePlayer = "Коля";
            playerInfo.PositionPlayer = transform.position;
            playerInfo.PositionPlayer.X = transform.position.x;
            playerInfo.PositionPlayer.Y = transform.position.y;
            playerInfo.PositionPlayer.Z = transform.position.z;
            //задаем стартовую позицию игрока
            Debug.Log($"позиция на старте X {playerInfo.PositionPlayer.X} Y {playerInfo.PositionPlayer.Y} Z {playerInfo.PositionPlayer.Z}");//проблема 1 почему выводит в дебаг  два варианта значения позиции объекта ? ( см принт скрин)
            

            #region "Работа с ссылками"
            //вар 1
            // GameObject playerGO = null; //GO обнуляем что бы скачать префаб с папки ресурсес
            // references = new References();//создаем экз класса для хранения ссылок на папку//
            // playerGO = references.Player;//блин говорит что ссылка пустая референсес не загрузился
            //вар 2
            //var _playerGO = Resources.Load<GameObject>("Player"); //дал прямую ссылку 
            //Object.Instantiate(_player, new Vector3(2, 4, 2), Quaternion.identity);//грузится куча клонов префабов и юнити вылетает
            //забить пока на загрузку из папки

            //var player = new Player("Федор",20,0);

            //playerInfo = new PlayerInfo("Lena", 34, 0);
            // var name1 = playerInfo._NamePlayer;
            #endregion

                      
            
        }

        public void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Bonus"))

            {
                
             var _goodbonus= other.GetComponent<GoodBonus>();
             var bonus= _goodbonus.Point;//получаем размер очков от сбора Бонуса
             playerInfo._Playerscore += bonus;
             Debug.Log($" стало {playerInfo._Playerscore}");
            }
        }

       

        void Update()
        {
           

            Debug.Log($"из апдейта счет  {playerInfo._Playerscore}");// Проблема 2 почему в дебаге два значения 0 и обновленное ?
        }


        public void GetDataPlayer()//на данном методе кнопка Save на канвасе. Не могу сюда передать обновленные данные по Обьекту игрока
        {
            var streamdata = new StreamData();
            var saved = new PlayerInfo();
            saved._NamePlayer = playerInfo._NamePlayer;
            saved._Playerscore = playerInfo._Playerscore;
           
            //удалить класс SaveGame
            //var pl = playerInfo;
            //if (game == null)
            //{ game = new SaveGame(pl); }
            //else 
            //{ 
            //  game.SaveGameonButton(pl);
                           
            //}

             Debug.Log($"счет игрока составляет { saved._Playerscore}");//проблема3  почему при нажатии кнопки в дебаге выводит значение 0 при увеличении количества бонусов, и не делает обновление значения ?
             streamdata.Save(saved, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData3.txt");//Проблема 4 почему в текстовом файле не сохраняются обновленные данные в GameControllers?
        }

    }
}
